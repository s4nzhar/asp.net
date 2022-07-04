using System.ComponentModel.DataAnnotations;
namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId {get; set;}

        //[MaxLength(5)]
        //[MinLength(1)]
        public Grade Grade { get; set; } 
    }
}
