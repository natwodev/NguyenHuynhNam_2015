using webphuckhao_api.Enums;
using System.ComponentModel.DataAnnotations;

namespace webphuckhao_api.DTOs
{
    public class UpdateRegradeStatusDTO
    {
        [Required]
        public RegradeStatus Status { get; set; }
    }
}