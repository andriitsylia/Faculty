using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Group")]
    public class Group
    {
        [Key]
        [Required]
        public int GroupId { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Group's name must be less than 30 symbols")]
        public string Name { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
