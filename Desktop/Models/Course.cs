using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class Course
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public int? Hours { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();

    public virtual ICollection<Ins_Crs> Instructors { get; set; } = new List<Ins_Crs>();

    public virtual ICollection<Std_Crs> Students { get; set; } = new List<Std_Crs>();
    public virtual ICollection<Question> Questions { get; set; }
}
