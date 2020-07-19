using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Edgenuity.RAD.Domain.Models
{
    public class Class
    {
        public Class()
        {
            Lessons = new List<Lesson>();
            StudentEnrollment = new List<Student>();
            EducatorEnrollment = new List<Educator>();
        }
        

        [Key]
        public long ClassID { get; set; }

        public Guid ClassGUID { get; set; } = Guid.NewGuid();

        [Required]
        public string ClassTitle { get; set; }
        [Required]
        public long OrganizationID { get; set; }
        [Required]
        public long OwnerID { get; set; }

        public List<ClassSubject> ClassSubjects { get; set; } 

        public List<Lesson> Lessons { get; set; }

        public List<Student> StudentEnrollment { get; set; }

        public List<Educator> EducatorEnrollment { get; set; }


    }
}
