using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH2_LSNU1C_Forms.Models;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssignedSubjects> AssignedSubjects { get; set; }

    public virtual DbSet<Enrollments> Enrollments { get; set; }

    public virtual DbSet<Students> Students { get; set; }

    public virtual DbSet<Subjects> Subjects { get; set; }

    public virtual DbSet<Teachers> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=lsnu1c.database.windows.net;Initial Catalog=lsnu1c_ZH4;Persist Security Info=True;User ID=hallgato;Password=Password123;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssignedSubjects>(entity =>
        {
            entity.HasKey(e => e.AssignId).HasName("PK__Assigned__32E5EDE64588AA40");

            entity.ToTable("Assigned_subjects");

            entity.Property(e => e.AssignId)
                .ValueGeneratedNever()
                .HasColumnName("assign_id");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

            entity.HasOne(d => d.Subject).WithMany(p => p.AssignedSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Assigned___subje__6754599E");

            entity.HasOne(d => d.Teacher).WithMany(p => p.AssignedSubjects)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Assigned___teach__68487DD7");
        });

        modelBuilder.Entity<Enrollments>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId);

            entity.Property(e => e.EnrollmentId).HasColumnName("enrollment_id");
            entity.Property(e => e.EnrollmentDate)
                .HasColumnType("date")
                .HasColumnName("enrollment_date");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Enrollmen__stude__693CA210");

            entity.HasOne(d => d.Subject).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Enrollmen__subje__6A30C649");
        });

        modelBuilder.Entity<Students>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__2A33069A8D41F82E");

            entity.HasIndex(e => e.Email, "UQ__Students__AB6E6164F4B396E9").IsUnique();

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("student_id");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Semester)
                .HasDefaultValueSql("((1))")
                .HasColumnName("semester");
        });

        modelBuilder.Entity<Subjects>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subjects__5004F6604FB5B8EE");

            entity.Property(e => e.SubjectId)
                .ValueGeneratedNever()
                .HasColumnName("subject_id");
            entity.Property(e => e.Semester).HasColumnName("semester");
            entity.Property(e => e.SubjectCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("subject_code");
            entity.Property(e => e.SubjectDescription)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("subject_description");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("subject_name");
        });

        modelBuilder.Entity<Teachers>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teachers__03AE777E50AA6C34");

            entity.HasIndex(e => e.Email, "UQ__Teachers__AB6E61642695AC67").IsUnique();

            entity.Property(e => e.TeacherId)
                .ValueGeneratedNever()
                .HasColumnName("teacher_id");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("last_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
