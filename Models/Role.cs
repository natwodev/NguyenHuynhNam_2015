using System.ComponentModel.DataAnnotations;

namespace NguyenHuynhNam_2015.Models;

public class Role
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Name { get; set; }  // "Admin", "NhanVien", "GiangVien", "SinhVien"
}
