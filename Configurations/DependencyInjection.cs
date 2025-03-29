using Microsoft.Extensions.DependencyInjection;
using NguyenHuynhNam_2015.Repositories;
using NguyenHuynhNam_2015.Services;

namespace NguyenHuynhNam_2015.Configurations
{
    public static class DependencyInjection
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            // Register Repositories
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ILecturerRepository, LecturerRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IRegradeRequestRepository, RegradeRequestRepository>();
            services.AddScoped<ITranscriptRepository, TranscriptRepository>();
            services.AddScoped<IRegradeDetailRepository, RegradeDetailRepository>();
            services.AddScoped<IDigitalExamRepository, DigitalExamRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            // Register Services
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ILecturerService, LecturerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IRegradeRequestService, RegradeRequestService>();
            services.AddScoped<ITranscriptService, TranscriptService>();
            services.AddScoped<IRegradeDetailService, RegradeDetailService>();
            services.AddScoped<IDigitalExamService, DigitalExamService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();

        }
    }
}