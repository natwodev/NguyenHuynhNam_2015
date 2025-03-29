using System.ComponentModel.DataAnnotations;

namespace NguyenHuynhNam_2015.Models
{
    // Class representing an academic major
    public class Major
    {
        // Primary key for the major, required and maximum 10 characters
        [Key]
        [Required]
        [MaxLength(10)]
        public string MajorId { get; set; }
        
        // Name of the major, required and maximum 100 characters
        [Required]
        [MaxLength(100)]
        public string MajorName { get; set; }
        
        // Collection of students associated with the major
        public ICollection<Student> Students { get; set; }
    }
}