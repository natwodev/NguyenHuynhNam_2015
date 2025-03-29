using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace NguyenHuynhNam_2015.Models
{
    // Class representing a job position
    public class Position
    {
        // Primary key for the position, required and maximum 10 characters (e.g., "CV001")
        [Key]
        [Required]
        [MaxLength(10)]
        public string PositionId { get; set; }
        
        // Name of the position, required and maximum 100 characters (e.g., "Lecturer", "Department Head")
        [Required]
        [MaxLength(100)]
        public string PositionName { get; set; }
        
        // Collection of employees associated with this position
        public ICollection<Employee>? Employees { get; set; }
    }
}