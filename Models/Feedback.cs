using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackMVC.Models
{
    public class Feedback
    {
        [Required]
        public string EnrollmentNo { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Subject { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }

        public string Comments { get; set; }
    }
}
