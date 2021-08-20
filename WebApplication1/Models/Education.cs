using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Proje1.Models
{
    public class Education
    {
        [DataMember]
        [Column("ID"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationId { get; set; }

        public string DepartmentName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime TerminationDate { get; set; }

        public string DegreeLevel { get; set; }

        public string UniversityName { get; set; }

        public int GPA { get; set; }

        //Navigation Property
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }


    }
}
