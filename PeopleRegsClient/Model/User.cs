using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleRegsClient.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        [Required()]
        public string Name { get; set; }

        public virtual ICollection<PersonRegistration> PersonRegistrations { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
