using System.ComponentModel.DataAnnotations;
namespace ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstMidName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }

        public List<Enrollment> StudentEnrollments { get; set; } = new List<Enrollment>();
    }
}
