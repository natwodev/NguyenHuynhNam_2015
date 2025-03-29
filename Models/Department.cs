using System.ComponentModel.DataAnnotations;

namespace NguyenHuynhNam_2015.Models
{
    // Class representing a department
    public class Department
    {
        // Primary key for the department, required and maximum 10 characters
        [Key]
        [Required]
        [MaxLength(10)]
        public string DepartmentId { get; set; }
        
        // Name of the department, required and maximum 100 characters
        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; }
        
        // Collection of classes associated with the department
        public ICollection<Class> Classes { get; set; }
        
        // Collection of lecturers associated with the department
        public ICollection<Lecturer> Lecturers { get; set; }
        
        // Collection of subjects associated with the department
        public ICollection<Subject> Subjects { get; set; }
        
        // Collection of employees associated with the department
        public ICollection<Employee> Employees { get; set; }
    }
}