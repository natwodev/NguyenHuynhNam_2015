using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Data
{
    // ApplicationDbContext sử dụng IdentityDbContext để hỗ trợ xác thực và phân quyền
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        // Định nghĩa các DbSet cho các thực thể với tên tiếng Anh
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<RegradeDetail> RegradeDetails { get; set; }
        public DbSet<RegradeRequest> RegradeRequests { get; set; }
        public DbSet<ExamSchedule> ExamSchedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<DigitalExam> DigitalExams { get; set; }
        
        public DbSet<User> Users { get; set; }  
        public DbSet<Role> Roles { get; set; }  

    }
}