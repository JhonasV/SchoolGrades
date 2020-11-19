
using System.ComponentModel.DataAnnotations;

namespace SchoolGrades.Models
{
    public class SchoolGrades
    {
        public int Id { get; set; }
        [Required]
        public string Cod { get; set; }
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public string CareerName { get; set; }
        [Required]
        public string Quater { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        public string GradeLiteral { get; set; }
    }
}
