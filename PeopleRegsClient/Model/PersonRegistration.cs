using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleRegsClient.Model
{
    public class PersonRegistration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(50)]
        [Required()]
        [DisplayName("Ime")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Required()]
        [DisplayName("Prezime")]
        public string LastName { get; set; }

        [StringLength(30)]
        [DisplayName("Telefon")]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Država")]
        public virtual Country Country { get; set; }

        [DisplayName("Država")]
        public string CountryName
        {
            get { return Country.Name; }
        }

        [StringLength(50)]
        [Required()]
        [DisplayName("Grad")]
        public string City { get; set; }

        [StringLength(200)]
        [DisplayName("Ulica i broj")]
        public string StreetAndNumber { get; set; }

        [DisplayName("Grad u BiH")]
        public virtual OriginCity OriginCity { get; set; }

        [DisplayName("Grad u BiH")]
        public string OriginCityName
        {
            get { return OriginCity.Name; }
        }

        [StringLength(200)]
        [DisplayName("Ulica i broj u BiH")]
        public string OriginStreetAndNumber { get; set; }

        [DisplayName("Zanimanje")]
        public virtual Occupation Occupation { get; set; }

        [DisplayName("Zanimanje")]
        public string OccupationName
        {
            get { return Occupation.Name; }
        }

        [DisplayName("Stručna sprema")]
        public virtual Qualification Qualification { get; set; }

        [DisplayName("Stručna sprema")]
        public string QualificationName
        {
            get { return Qualification.Name; }
        }

        [DisplayName("Glasao na preth. izborima")]
        public bool VotedOnPreviousElections { get; set; }

        [DisplayName("Status registracije")]
        public virtual VotingRegistrationStatus VotingRegistrationStatus { get; set; }

        [DisplayName("Status registracije")]
        public string VotingRegistrationStatusName
        {
            get { return VotingRegistrationStatus.Name; }
        }

        [DisplayName("Prijavljen u općini")]
        public virtual OriginCity VotingRegistrationCity { get; set; }

        [DisplayName("Prijavljen u općini")]
        public string VotingRegistrationCityName
        {
            get { return VotingRegistrationCity.Name; }
        }
        
        [DisplayName("Građanin BiH")]
        public bool IsCitizenOfBih { get; set; }

        [StringLength(2000)]
        [DisplayName("Bilješke")]
        public string Note { get; set; }

        [DisplayName("Datum upisa")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Upisao")]
        public virtual User CreatedBy { get; set; }
    }
}
