using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Proje1.Models
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperienceId { get; set; }

        public string CompanyName { get; set; }

        public string JobPosition { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime TerminationDate { get; set; }

        public string Location { get; set; }


        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
