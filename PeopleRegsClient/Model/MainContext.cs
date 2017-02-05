using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleRegsClient.Model
{
    public class MainContext : DbContext
    {
        public MainContext() : base("MainContext")
        {
            Database.SetInitializer<MainContext>(new CreateDatabaseIfNotExists<MainContext>());
        }

        public DbSet<PersonRegistration> PersonRegistrations { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<OriginCity> OriginCities { get; set; }

        public DbSet<Occupation> Occupations { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }

        public DbSet<VotingRegistrationStatus> VotingRegistrationStatuses { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
