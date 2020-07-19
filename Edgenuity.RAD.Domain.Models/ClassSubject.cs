using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Edgenuity.RAD.Domain.Models
{
    public class ClassSubject
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Code { get; set; }

        [Required, MaxLength(400)]
        public string Title { get; set; }
    }
}
