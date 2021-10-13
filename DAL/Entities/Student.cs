using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Required]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "FirstName must be less than 30 symbols")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "LastName must be less than 30 symbols")]
        public string LastName { get; set; }

        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }

        public Group Group { get; set; }
    }
}
