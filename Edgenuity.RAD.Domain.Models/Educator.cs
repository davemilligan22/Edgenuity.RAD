using System.ComponentModel.DataAnnotations;

namespace Edgenuity.RAD.Domain.Models
{
    public class Educator
    {
        public Educator()
        {
        }

        public Educator(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        [Key]
        public long Id { get; set; }

        [Required, MaxLength(200), MinLength(1)]
        public string FirstName { get; set; }

        [Required, MaxLength(200), MinLength(1)]
        public string LastName { get; set; }

    }
}
