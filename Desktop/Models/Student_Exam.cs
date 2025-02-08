using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop.Models;

public partial class Student_Exam
{
    public int StdID { get; set; }

    public int ExamID { get; set; }

    public int? Grade { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    [ForeignKey("StdID")]
    public virtual Student Student { get; set; } = null!;
}
