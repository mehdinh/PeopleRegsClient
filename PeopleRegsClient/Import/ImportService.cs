using Newtonsoft.Json;
using PeopleRegsClient.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PeopleRegsClient.Import
{
    public class ImportService
    {
        public void ImportData()
        {
            try
            {
                List<PersonRegistrationEntry> personRegistrations = getNextEntries();

                foreach (var personRegistration in personRegistrations)
                {
                    using (var context = new MainContext())
                    {
                        if (!context.Countries.Any(e => e.Id == personRegistration.CountryId))
                        {
                            context.Countries.Add(new Country() { Id = personRegistration.CountryId, Name = personRegistration.CountryName });
                            context.SaveChanges();
                        }

                        if (!context.OriginCities.Any(e => e.Id == personRegistration.OriginCityId))
                        {
                            context.OriginCities.Add(new OriginCity() { Id = personRegistration.OriginCityId, Name = personRegistration.OriginCityName });
                            context.SaveChanges();
                        }

                        if (!context.Occupations.Any(e => e.Id == personRegistration.OccupationId))
                        {
                            context.Occupations.Add(new Occupation() { Id = personRegistration.OccupationId, Name = personRegistration.OccupationName });
                            context.SaveChanges();
                        }

                        if (!context.Qualifications.Any(e => e.Id == personRegistration.QualificationId))
                        {
                            context.Qualifications.Add(new Qualification() { Id = personRegistration.QualificationId, Name = personRegistration.QualificationName });
                            context.SaveChanges();
                        }

                        if (!context.VotingRegistrationStatuses.Any(e => e.Id == personRegistration.VotingRegistrationStatusId))
                        {
                            context.VotingRegistrationStatuses.Add(new VotingRegistrationStatus() { Id = personRegistration.VotingRegistrationStatusId, Name = personRegistration.VotingRegistrationStatusName });
                            context.SaveChanges();
                        }

                        if (!context.OriginCities.Any(e => e.Id == personRegistration.VotingRegistrationCityId))
                        {
                            context.OriginCities.Add(new OriginCity() { Id = personRegistration.VotingRegistrationCityId, Name = personRegistration.VotingRegistrationCityName });
                            context.SaveChanges();
                        }

                        if (!context.Users.Any(e => e.Id == personRegistration.CreatedById))
                        {
                            context.Users.Add(new User() { Id = personRegistration.CreatedById, Name = personRegistration.CreatedByUsername });
                            context.SaveChanges();
                        }

                        context.PersonRegistrations.Add(new PersonRegistration()
                        {
                            Id = personRegistration.Id,
                            FirstName = personRegistration.FirstName,
                            LastName = personRegistration.LastName,
                            PhoneNumber = personRegistration.PhoneNumber,
                            Email = personRegistration.Email,
                            Country = context.Countries.Where(e => e.Id == personRegistration.CountryId).FirstOrDefault(),
                            City = personRegistration.City,
                            StreetAndNumber = personRegistration.StreetAndNumber,
                            OriginCity = context.OriginCities.Where(e => e.Id == personRegistration.OriginCityId).FirstOrDefault(),
                            OriginStreetAndNumber = personRegistration.OriginStreetAndNumber,
                            Occupation = context.Occupations.Where(e => e.Id == personRegistration.OccupationId).FirstOrDefault(),
                            Qualification = context.Qualifications.Where(e => e.Id == personRegistration.QualificationId).FirstOrDefault(),
                            VotedOnPreviousElections = personRegistration.VotedOnPreviousElections,
                            VotingRegistrationStatus = context.VotingRegistrationStatuses.Where(e => e.Id == personRegistration.VotingRegistrationStatusId).FirstOrDefault(),
                            VotingRegistrationCity = context.OriginCities.Where(e => e.Id == personRegistration.VotingRegistrationCityId).FirstOrDefault(),
                            IsCitizenOfBih = personRegistration.IsCitizenOfBih,
                            Note = personRegistration.Note,
                            CreatedAt = personRegistration.CreatedAt,
                            CreatedBy = context.Users.Where(e => e.Id == personRegistration.CreatedById).FirstOrDefault()
                        });
                        context.SaveChanges();
                    }
                }
            }
            catch
            { }
        }

        private List<PersonRegistrationEntry> getNextEntries()
        {            
            string lastSeenId = "0";
            using (var context = new MainContext())
            {
                var lastRecords = context.PersonRegistrations.OrderByDescending(e => e.Id).Take(1);
                if (lastRecords.Count() > 0)
                {
                    lastSeenId = lastRecords.First().Id.ToString();
                }
            }

            string count = ConfigurationManager.AppSettings["maxEntriesPerRequest"];
            string syncCopy = ConfigurationManager.AppSettings["syncCopy"].Trim().ToLower() == "true" ? "1" : "0";
            string deleteSyncedEntries = ConfigurationManager.AppSettings["deleteSyncedEntries"].Trim().ToLower() == "true" ? "1" : "0";
            string url = ConfigurationManager.AppSettings["serviceUrl"] + "?lastSeenId=" + lastSeenId + "&count=" + count + "&syncCopy=" + syncCopy + "&deleteSyncedEntries=" + deleteSyncedEntries;

            List<PersonRegistrationEntry> result = null;
            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                string jsonData = webClient.DownloadString(url);
                result = JsonConvert.DeserializeObject<List<PersonRegistrationEntry>>(jsonData);
            }

            return result;
        }
    }   
}
