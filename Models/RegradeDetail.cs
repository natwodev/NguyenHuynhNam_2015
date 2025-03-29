using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NguyenHuynhNam_2015.Enums;

namespace NguyenHuynhNam_2015.Models
{
    // Class representing the details of a regrade process
    public class RegradeDetail
    {
        // Primary key for the regrade detail, auto-generated
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegradeDetailId { get; set; }
        
        // Foreign key linking to the regrade request, required
        [Required]
        [ForeignKey("RegradeRequest")]
        public int RegradeRequestId { get; set; }
        // Navigation property for the associated regrade request
        public RegradeRequest RegradeRequest { get; set; }

        // Regrade result (score after regrade), optional
        public double? RegradeResult { get; set; }
        
        // Note from the lecturer, optional and maximum 500 characters
        [MaxLength(500)]
        public string? Note { get; set; }
        
        // Date when the lecturer regraded, optional
        public DateTime? RegradeDate { get; set; }
        
        // Status of the regrade process (e.g., "Pending", "Graded", "Rejected"), optional and maximum 20 characters
        [MaxLength(20)]
        
        public RegradeStatus RegradeStatus { get; set; } = RegradeStatus.Pending;

        
        // Foreign key linking to the lecturer, required and maximum 10 characters
        [Required]
        [MaxLength(10)]
        [ForeignKey("Lecturer")]
        public string LecturerId { get; set; }
        // Navigation property for the associated lecturer
        public Lecturer Lecturer { get; set; }
        

    }
}