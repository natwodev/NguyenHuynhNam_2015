using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace NguyenHuynhNam_2015.Models
{
    // Class representing a student class
    public class Class
    {
        // Primary key for the class, required and maximum 10 characters
        [Key]
        [Required]
        [MaxLength(10)]
        public string ClassId { get; set; }
        
        // Name of the class, required and maximum 100 characters
        [Required]
        [MaxLength(100)]
        public string ClassName { get; set; }
        
        // Foreign key for the department, required and maximum 10 characters
        [Required]
        [MaxLength(10)]
        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        
        // Associated Department object
        public Department Department { get; set; }
        
        // Collection of students in the class
        public ICollection<Student> Students { get; set; }
    }
}