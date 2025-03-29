using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webphuckhao_api.Models
{
    // Class representing a semester
    public class Semester
    {
        // Primary key for the semester, required
        [Key]
        [Required]
        public int SemesterId { get; set; }

        // Name of the semester (e.g., "Semester 1", "Semester 2"), required and maximum 100 characters
        [Required]
        [MaxLength(100)]
        public string SemesterName { get; set; }

        // Start date of the semester, required
        [Required]
        public DateTime StartDate { get; set; }

        // End date of the semester, required
        [Required]
        public DateTime EndDate { get; set; }

        // Optional regrade start date
        public DateTime? RegradeStartDate { get; set; }

        // Optional regrade end date
        public DateTime? RegradeEndDate { get; set; }

        // Foreign key for the academic year, required
        [Required]
        [ForeignKey("AcademicYear")]
        public int AcademicYearId { get; set; }
        // Navigation property for the associated academic year
        public AcademicYear AcademicYear { get; set; }

        // Collection of exam schedules associated with the semester
        public ICollection<ExamSchedule> ExamSchedules { get; set; }
    }
}