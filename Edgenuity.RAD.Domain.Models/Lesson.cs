using System;
using System.ComponentModel.DataAnnotations;

namespace Edgenuity.RAD.Domain.Models
{
    public class Lesson
    {
        [Key]
        public Guid Id { get; set; }

        public long SubjectId { get; set; }

        [Required, MaxLength(800)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }
    }
}
