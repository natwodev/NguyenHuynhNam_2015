namespace NguyenHuynhNam_2015.DTOs
{
    // DTO for Student data
    public class StudentDTO
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CitizenId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public byte[]? Image { get; set; }
        
        public string ClassId { get; set; }
        public string ClassName { get; set; }

        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public string? MajorId { get; set; }
        public string? MajorName { get; set; }
    }
}