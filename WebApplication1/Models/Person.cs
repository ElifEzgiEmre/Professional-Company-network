using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Proje1.Models
{
    public class Person
    {
        [DataMember]
        [Column("PersonId"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string Address { get; set; }

        public string ImageUrl { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public string Website { get; set; }

        public string Twitter { get; set; }

        public virtual List<Education> Educations { get; set; }
        public virtual List<Experience> Experiences { get; set; }
    }
}
