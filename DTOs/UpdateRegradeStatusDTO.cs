using NguyenHuynhNam_2015.Enums;
using System.ComponentModel.DataAnnotations;

namespace NguyenHuynhNam_2015.DTOs
{
    public class UpdateRegradeStatusDTO
    {
        [Required]
        public RegradeStatus Status { get; set; }
    }
}