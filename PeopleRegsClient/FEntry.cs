using PeopleRegsClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleRegsClient
{
    public partial class FEntry : Form
    {
        public FEntry(PersonRegistration personRegistration)
        {
            InitializeComponent();

            this.personRegistration = personRegistration;

            loadDropdownEdits();
            showData();
        }

        private PersonRegistration personRegistration;

        private void loadDropdownEdits()
        {
            using (var context = new MainContext())
            {
                countryEdit.DataSource = context.Countries.OrderBy(e => e.Name).ToList();
                originCityEdit.DataSource = context.OriginCities.OrderBy(e => e.Name).ToList();
                occupationEdit.DataSource = context.Occupations.OrderBy(e => e.Name).ToList();
                qualificationEdit.DataSource = context.Qualifications.OrderBy(e => e.Name).ToList();
                votingRegistrationStatusEdit.DataSource = context.VotingRegistrationStatuses.OrderBy(e => e.Name).ToList();
                votingRegistrationCityEdit.DataSource = context.OriginCities.OrderBy(e => e.Name).ToList();
            }
                
        }

        private void showData()
        {
            fullNameLabel.Text = personRegistration.FirstName + " " + personRegistration.LastName;

            firstNameEdit.Text = personRegistration.FirstName;
            lastNameEdit.Text = personRegistration.LastName;
            phoneNumberEdit.Text = personRegistration.PhoneNumber;
            emailEdit.Text = personRegistration.Email;

            countryEdit.SelectedItem = (countryEdit.DataSource as List<Country>).Where(e => e.Id == personRegistration.Country.Id).FirstOrDefault();
            cityEdit.Text = personRegistration.City;
            streetAndNumberEdit.Text = personRegistration.StreetAndNumber;

            originCityEdit.SelectedItem = (originCityEdit.DataSource as List<OriginCity>).Where(e => e.Id == personRegistration.OriginCity.Id).FirstOrDefault();
            originStreetAndNumberEdit.Text = personRegistration.OriginStreetAndNumber;

            occupationEdit.SelectedItem = (occupationEdit.DataSource as List<Occupation>).Where(e => e.Id == personRegistration.Occupation.Id).FirstOrDefault();
            qualificationEdit.SelectedItem = (qualificationEdit.DataSource as List<Qualification>).Where(e => e.Id == personRegistration.Qualification.Id).FirstOrDefault();

            votingRegistrationStatusEdit.SelectedItem = (votingRegistrationStatusEdit.DataSource as List<VotingRegistrationStatus>).Where(e => e.Id == personRegistration.VotingRegistrationStatus.Id).FirstOrDefault();
            votingRegistrationCityEdit.SelectedItem = (votingRegistrationCityEdit.DataSource as List<OriginCity>).Where(e => e.Id == personRegistration.VotingRegistrationCity.Id).FirstOrDefault();
            votedOnPreviousElectionsEdit.Checked = personRegistration.VotedOnPreviousElections;
            isCitizenOfBihEdit.Checked = personRegistration.IsCitizenOfBih;

            noteEdit.Text = personRegistration.Note;
        }

        private bool validateData()
        {
            if (firstNameEdit.Text.Trim() == "")
            {
                MessageBox.Show("Ime je obavezno");
                firstNameEdit.Focus();
                return false;
            }

            if (lastNameEdit.Text.Trim() == "")
            {
                MessageBox.Show("Prezime je obavezno");
                lastNameEdit.Focus();
                return false;
            }

            if (cityEdit.Text.Trim() == "")
            {
                MessageBox.Show("Grad je obavezan");
                cityEdit.Focus();
                return false;
            }

            return true;
        }

        private void save()
        {
            using (var context = new MainContext())
            {
                var entity = context.PersonRegistrations.Where(e => e.Id == personRegistration.Id).FirstOrDefault();

                entity.FirstName = firstNameEdit.Text.Trim();
                entity.LastName = lastNameEdit.Text.Trim();
                entity.PhoneNumber = phoneNumberEdit.Text.Trim();
                entity.Email = emailEdit.Text.Trim();

                var countryId = (countryEdit.SelectedItem as Country).Id;
                entity.Country = context.Countries.Where(e => e.Id == countryId).FirstOrDefault();

                entity.City = cityEdit.Text.Trim();
                entity.StreetAndNumber = streetAndNumberEdit.Text.Trim();

                var originCityId = (originCityEdit.SelectedItem as OriginCity).Id;
                entity.OriginCity = context.OriginCities.Where(e => e.Id == originCityId).FirstOrDefault();

                entity.OriginStreetAndNumber = originStreetAndNumberEdit.Text.Trim();

                var occupationId = (occupationEdit.SelectedItem as Occupation).Id;
                entity.Occupation = context.Occupations.Where(e => e.Id == occupationId).FirstOrDefault();

                var qualificationId = (qualificationEdit.SelectedItem as Qualification).Id;
                entity.Qualification = context.Qualifications.Where(e => e.Id == qualificationId).FirstOrDefault();

                var votingRegistrationStatusId = (votingRegistrationStatusEdit.SelectedItem as VotingRegistrationStatus).Id;
                entity.VotingRegistrationStatus = context.VotingRegistrationStatuses.Where(e => e.Id == votingRegistrationStatusId).FirstOrDefault();

                var votingRegistrationCityId = (votingRegistrationCityEdit.SelectedItem as OriginCity).Id;
                entity.VotingRegistrationCity = context.OriginCities.Where(e => e.Id == votingRegistrationCityId).FirstOrDefault();

                entity.VotedOnPreviousElections = votedOnPreviousElectionsEdit.Checked;
                entity.IsCitizenOfBih = isCitizenOfBihEdit.Checked;

                entity.Note = noteEdit.Text.Trim();

                context.SaveChanges();

                personRegistration.FirstName = entity.FirstName;
                personRegistration.LastName = entity.LastName;
                personRegistration.PhoneNumber = entity.PhoneNumber;
                personRegistration.Email = entity.Email;
                personRegistration.Country = entity.Country;
                personRegistration.City = entity.City;
                personRegistration.StreetAndNumber = entity.StreetAndNumber;
                personRegistration.OriginCity = entity.OriginCity;
                personRegistration.OriginStreetAndNumber = entity.OriginStreetAndNumber;
                personRegistration.Occupation = entity.Occupation;
                personRegistration.Qualification = entity.Qualification;
                personRegistration.VotingRegistrationStatus = entity.VotingRegistrationStatus;
                personRegistration.VotingRegistrationCity = entity.VotingRegistrationCity;
                personRegistration.VotedOnPreviousElections = entity.VotedOnPreviousElections;
                personRegistration.IsCitizenOfBih = entity.IsCitizenOfBih;
                personRegistration.Note = entity.Note;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                save();
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
