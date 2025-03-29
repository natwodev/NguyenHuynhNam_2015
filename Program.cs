using NguyenHuynhNam_2015.Extensions; // Import AppExtensions

var builder = WebApplication.CreateBuilder(args);


// Đọc cấu hình từ appsettings.json
var configuration = builder.Configuration;
// Đăng ký dịch vụ
builder.Services.ConfigureServices(configuration);

var app = builder.Build();

// Gọi middleware đã tách ra
app.ConfigureMiddleware();

app.Run();