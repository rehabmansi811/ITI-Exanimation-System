using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class Student
{
    public int StdID { get; set; }

    public int IntakeID { get; set; }

    public string? College { get; set; }

    public virtual ICollection<Answer_Exam> Answer_Exams { get; set; } = new List<Answer_Exam>();

    public virtual Intake Intake { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<Student_Exam> Exams { get; set; } = new List<Student_Exam>();

    public virtual ICollection<Std_Crs> Courses { get; set; } = new List<Std_Crs>();
}
