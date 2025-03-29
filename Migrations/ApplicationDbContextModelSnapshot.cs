﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webphuckhao_api.Data;

#nullable disable

namespace NguyenHuynhNam_2015.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webphuckhao_api.Models.AcademicYear", b =>
                {
                    b.Property<int>("AcademicYearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcademicYearId"));

                    b.Property<string>("AcademicYearName")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AcademicYearId");

                    b.ToTable("AcademicYears");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ClassId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Department", b =>
                {
                    b.Property<string>("DepartmentId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("webphuckhao_api.Models.DigitalExam", b =>
                {
                    b.Property<int>("DigitalExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DigitalExamId"));

                    b.Property<string>("AnswerFilePath")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("AnswerFileUploadDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamFilePath")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("ExamFileUploadDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TranscriptId")
                        .HasColumnType("int");

                    b.HasKey("DigitalExamId");

                    b.HasIndex("TranscriptId")
                        .IsUnique()
                        .HasFilter("[TranscriptId] IS NOT NULL");

                    b.ToTable("DigitalExams");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CitizenId")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(MAX)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PositionId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("webphuckhao_api.Models.ExamSchedule", b =>
                {
                    b.Property<int>("ExamScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamScheduleId"));

                    b.Property<DateTime>("ExamDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ExamScheduleId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ExamSchedules");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Lecturer", b =>
                {
                    b.Property<string>("LecturerId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CitizenId")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(MAX)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("LecturerId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Major", b =>
                {
                    b.Property<string>("MajorId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MajorId");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Position", b =>
                {
                    b.Property<string>("PositionId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("webphuckhao_api.Models.RegradeDetail", b =>
                {
                    b.Property<int>("RegradeDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegradeDetailId"));

                    b.Property<string>("LecturerId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("RegradeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegradeRequestId")
                        .HasColumnType("int");

                    b.Property<double?>("RegradeResult")
                        .HasColumnType("float");

                    b.Property<int>("RegradeStatus")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.HasKey("RegradeDetailId");

                    b.HasIndex("LecturerId");

                    b.HasIndex("RegradeRequestId");

                    b.ToTable("RegradeDetails");
                });

            modelBuilder.Entity("webphuckhao_api.Models.RegradeRequest", b =>
                {
                    b.Property<int>("RegradeRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegradeRequestId"));

                    b.Property<string>("ApprovingEmployeeId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double?>("DesiredScore")
                        .HasColumnType("float");

                    b.Property<string>("EmployeeNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("RequestCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("TranscriptId")
                        .HasColumnType("int");

                    b.HasKey("RegradeRequestId");

                    b.HasIndex("ApprovingEmployeeId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TranscriptId");

                    b.ToTable("RegradeRequests");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Semester", b =>
                {
                    b.Property<int>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemesterId"));

                    b.Property<int>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RegradeEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RegradeStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SemesterId");

                    b.HasIndex("AcademicYearId");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CitizenId")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(MAX)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("MajorId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("MajorId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Subject", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("HasExam")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SubjectId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Transcript", b =>
                {
                    b.Property<int>("TranscriptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TranscriptId"));

                    b.Property<double?>("ComponentScore")
                        .HasColumnType("float");

                    b.Property<double?>("FinalScore")
                        .HasColumnType("float");

                    b.Property<double?>("MidtermScore")
                        .HasColumnType("float");

                    b.Property<double?>("ScoreAfterRegrade")
                        .HasColumnType("float");

                    b.Property<int?>("SemesterId")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double?>("TotalScore")
                        .HasColumnType("float");

                    b.HasKey("TranscriptId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Transcripts");
                });

            modelBuilder.Entity("webphuckhao_api.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Class", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Department", "Department")
                        .WithMany("Classes")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("webphuckhao_api.Models.DigitalExam", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Transcript", "Transcript")
                        .WithOne("DigitalExam")
                        .HasForeignKey("webphuckhao_api.Models.DigitalExam", "TranscriptId");

                    b.Navigation("Transcript");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Employee", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Department", null)
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("webphuckhao_api.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("webphuckhao_api.Models.ExamSchedule", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Semester", "Semester")
                        .WithMany("ExamSchedules")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webphuckhao_api.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Lecturer", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Department", "Department")
                        .WithMany("Lecturers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("webphuckhao_api.Models.RegradeDetail", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Lecturer", "Lecturer")
                        .WithMany()
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webphuckhao_api.Models.RegradeRequest", "RegradeRequest")
                        .WithMany()
                        .HasForeignKey("RegradeRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");

                    b.Navigation("RegradeRequest");
                });

            modelBuilder.Entity("webphuckhao_api.Models.RegradeRequest", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Employee", "ApprovingEmployee")
                        .WithMany()
                        .HasForeignKey("ApprovingEmployeeId");

                    b.HasOne("webphuckhao_api.Models.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webphuckhao_api.Models.Student", "Student")
                        .WithMany("RegradeRequests")
                        .HasForeignKey("StudentId");

                    b.HasOne("webphuckhao_api.Models.Transcript", "Transcript")
                        .WithMany()
                        .HasForeignKey("TranscriptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApprovingEmployee");

                    b.Navigation("Semester");

                    b.Navigation("Student");

                    b.Navigation("Transcript");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Semester", b =>
                {
                    b.HasOne("webphuckhao_api.Models.AcademicYear", "AcademicYear")
                        .WithMany("Semesters")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicYear");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Student", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webphuckhao_api.Models.Major", "Major")
                        .WithMany("Students")
                        .HasForeignKey("MajorId");

                    b.Navigation("Class");

                    b.Navigation("Major");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Subject", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Department", "Department")
                        .WithMany("Subjects")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Transcript", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterId");

                    b.HasOne("webphuckhao_api.Models.Student", "Student")
                        .WithMany("Transcripts")
                        .HasForeignKey("StudentId");

                    b.HasOne("webphuckhao_api.Models.Subject", "Subject")
                        .WithMany("Transcripts")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Semester");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("webphuckhao_api.Models.User", b =>
                {
                    b.HasOne("webphuckhao_api.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("webphuckhao_api.Models.AcademicYear", b =>
                {
                    b.Navigation("Semesters");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Department", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Employees");

                    b.Navigation("Lecturers");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Major", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Semester", b =>
                {
                    b.Navigation("ExamSchedules");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Student", b =>
                {
                    b.Navigation("RegradeRequests");

                    b.Navigation("Transcripts");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Subject", b =>
                {
                    b.Navigation("Transcripts");
                });

            modelBuilder.Entity("webphuckhao_api.Models.Transcript", b =>
                {
                    b.Navigation("DigitalExam");
                });
#pragma warning restore 612, 618
        }
    }
}
