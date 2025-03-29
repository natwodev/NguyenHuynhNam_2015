using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webphuckhao_api.Models
{
    // Class representing an academic year
    public class AcademicYear
    {
        // Primary key for the academic year, required
        [Key]
        [Required]
        public int AcademicYearId { get; set; }

        // Name of the academic year (e.g., "2024-2025"), required and maximum 9 characters
        [Required]
        [MaxLength(9)]
        public string AcademicYearName { get; set; }

        // Start date of the academic year, required
        [Required]
        public DateTime StartDate { get; set; }

        // End date of the academic year, required
        [Required]
        public DateTime EndDate { get; set; }

        // Collection of semesters associated with the academic year
        public ICollection<Semester> Semesters { get; set; }
    }
}