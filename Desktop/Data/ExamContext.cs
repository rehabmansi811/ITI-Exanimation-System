using System;
using System.Collections.Generic;
using Desktop.Models;
using Microsoft.EntityFrameworkCore;

namespace Desktop.Data;

public partial class ExamContext : DbContext
{
    public ExamContext()
    {
    }

    public ExamContext(DbContextOptions<ExamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Answer_Exam> Answer_Exams { get; set; }

    public virtual DbSet<Choice> Choices { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Intake> Intakes { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Student_Exam> Student_Exams { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Ins_Crs> InstructorCourses { get; set; }
    
    public virtual DbSet<Std_Crs> StudentCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=YEARO_EXAM_SYSTEM;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ins_Crs>(entity =>
        {
            entity.HasKey(e => new { e.InsID, e.CrsID }).HasName("PK__Ins_Crs__52BC6EE43E5627D0");

            entity.ToTable("Ins_Crs");

            entity.HasOne(e=>e.Instructor).WithMany(p=>p.Courses)
            .HasForeignKey(e=>e.InsID)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK__Ins_Crs__InsID__571DF1D5");

            entity.HasOne(e => e.Course).WithMany(p => p.Instructors)
            .HasForeignKey(e => e.CrsID)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK__Ins_Crs__CrsID__5812160E");
        });

        modelBuilder.Entity<Std_Crs>(entity =>
        {
            entity.HasKey(e => new { e.StdID, e.CrsID }).HasName("PK__Std_Crs__9A708D54FCA9C1D6");

            entity.ToTable("Std_Crs");

            entity.HasOne(e => e.Student).WithMany(p => p.Courses)
            .HasForeignKey(e => e.StdID)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK__Std_Crs__StdID__534D60F1");

            entity.HasOne(e => e.Course).WithMany(p => p.Students)
            .HasForeignKey(e => e.CrsID)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK__Std_Crs__CrsID__5441852A");
        });

        modelBuilder.Entity<Answer_Exam>(entity =>
        {
            entity.HasKey(e => new { e.ExamID, e.QID, e.StdID }).HasName("PK__Answer_E__BB8BE975750EB0CA");

            entity.ToTable("Answer_Exam");

            entity.Property(e => e.Answer).HasDefaultValue(0);

            entity.HasOne(d => d.Exam).WithMany(p => p.Answers)
                .HasForeignKey(d => d.ExamID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Answer_Ex__ExamI__6B24EA82");

            entity.HasOne(d => d.Question).WithMany(p => p.Answer_Exams)
                .HasForeignKey(d => d.QID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Answer_Exam__QID__6C190EBB");

            entity.HasOne(d => d.Student).WithMany(p => p.Answer_Exams)
                .HasForeignKey(d => d.StdID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Answer_Ex__StdID__6D0D32F4");
        });

        modelBuilder.Entity<Choice>(entity =>
        {
            entity.HasKey(e => new { e.QID, e.ChoiceNum }).HasName("PK__Choice__387F3533A01C340D");

            entity.ToTable("Choice");

            entity.Property(e => e.ChoiceNum).HasColumnName("Choice");
            entity.Property(e => e.Body).HasColumnName("Body");

            entity.HasOne(d => d.Question).WithMany(p => p.Choices)
                .HasForeignKey(d => d.QID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Choice__QID__6754599E");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Course__3214EC278FF68A2D");

            entity.ToTable("Course");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Departme__3214EC27B3839EB5");

            entity.ToTable("Department");

            entity.Property(e => e.Describe).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Exam__3214EC27F9F7FD7D");

            entity.ToTable("Exam");

            entity.Property(e => e.EndDate).HasComputedColumnSql("(dateadd(hour,(1),[startdate]))", true);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CrsID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Exam__CrsID__5AEE82B9");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsID).HasName("PK__Instruct__9D104D8F4D83BC15");

            entity.ToTable("Instructor");

            entity.Property(e => e.InsID).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithOne(p => p.Instructor)
                .HasForeignKey<Instructor>(d => d.InsID)
                .HasConstraintName("FK__Instructo__InsID__4AB81AF0");
        });

        modelBuilder.Entity<Intake>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Intake__3214EC271EAB213C");

            entity.ToTable("Intake");

            entity.Property(e => e.EndDate).HasComputedColumnSql("(dateadd(month,(12),[startdate]))", true);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Person__3214EC273DCD2E0A");

            entity.ToTable("Person");

            entity.HasIndex(e => e.Email, "UQ__Person__A9D1053458638C48").IsUnique();

            entity.HasIndex(e => e.NID, "UQ__Person__C7DEC3329D485007").IsUnique();

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NID).HasMaxLength(14);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.Role).HasMaxLength(30);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Department).WithMany(p => p.People)
                .HasForeignKey(d => d.DeptID)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Person__DeptID__440B1D61");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Question__3214EC2723ECC411");

            entity.ToTable("Question");

            entity.HasOne(d => d.Course).WithMany(p => p.Questions).HasForeignKey(p => p.CrsID);

            entity.Property(e => e.CorrectChoice).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(10);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StdID).HasName("PK__Student__55DCAE3F8FE39373");

            entity.ToTable("Student");

            entity.Property(e => e.StdID).ValueGeneratedNever();
            entity.Property(e => e.College).HasMaxLength(255);

            entity.HasOne(d => d.Intake).WithMany(p => p.Students)
                .HasForeignKey(d => d.IntakeID)
                .HasConstraintName("FK__Student__College__46E78A0C");

            entity.HasOne(d => d.Person).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.StdID)
                .HasConstraintName("FK__Student__StdID__47DBAE45");
        });

        modelBuilder.Entity<Student_Exam>(entity =>
        {
            entity.HasKey(e => new { e.StdID, e.ExamID }).HasName("PK__Student___374BFC25DE7BEF55");

            entity.ToTable("Student_Exam");

            entity.HasOne(d => d.Exam).WithMany(p => p.Students)
                .HasForeignKey(d => d.ExamID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Student_E__ExamI__5EBF139D");

            entity.HasOne(d => d.Student).WithMany(p => p.Exams)
                .HasForeignKey(d => d.StdID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Student_E__StdID__5DCAEF64");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Topic__3214EC2700575E4D");

            entity.ToTable("Topic");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Course).WithMany(p => p.Topics)
                .HasForeignKey(d => d.CrsID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Topic__CrsID__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
