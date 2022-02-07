using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DbFirstEF.Models
{
    public partial class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentTeacher> StudentTeachers { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.GradeId, "IX_Students_GradeId");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GradeId);
            });

            modelBuilder.Entity<StudentTeacher>(entity =>
            {
                entity.HasKey(e => new { e.StudentsStudentId, e.TeachersTeacherId });

                entity.ToTable("StudentTeacher");

                entity.HasIndex(e => e.TeachersTeacherId, "IX_StudentTeacher_TeachersTeacherId");

                entity.HasOne(d => d.StudentsStudent)
                    .WithMany(p => p.StudentTeachers)
                    .HasForeignKey(d => d.StudentsStudentId);

                entity.HasOne(d => d.TeachersTeacher)
                    .WithMany(p => p.StudentTeachers)
                    .HasForeignKey(d => d.TeachersTeacherId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
