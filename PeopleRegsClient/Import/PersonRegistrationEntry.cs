using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleRegsClient.Import
{
    public class PersonRegistrationEntry
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public string City { get; set; }

        public string StreetAndNumber { get; set; }

        public int OriginCityId { get; set; }

        public string OriginCityName { get; set; }

        public string OriginStreetAndNumber { get; set; }

        public int OccupationId { get; set; }

        public string OccupationName { get; set; }

        public int QualificationId { get; set; }

        public string QualificationName { get; set; }

        public bool VotedOnPreviousElections { get; set; }

        public int VotingRegistrationStatusId { get; set; }

        public string VotingRegistrationStatusName { get; set; }

        public int VotingRegistrationCityId { get; set; }

        public string VotingRegistrationCityName { get; set; }

        public bool IsCitizenOfBih { get; set; }

        public string Note { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedById { get; set; }

        public string CreatedByUsername { get; set; }
    }
}
