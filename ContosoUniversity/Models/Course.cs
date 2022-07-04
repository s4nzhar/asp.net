using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public List<Enrollment> StudentEnrollments { get; set; } = new List<Enrollment>();

    }
}
