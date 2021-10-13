using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        [Required]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Course's name must be less than 30 symbols")]
        public string Name { get; set; }

        [MaxLength(256, ErrorMessage = "Description must be less than 256 symbols")]
        public string Description { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
