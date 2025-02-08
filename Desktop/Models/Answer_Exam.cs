using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop.Models;

public partial class Answer_Exam
{
    public int ExamID { get; set; }

    public int QID { get; set; }

    public int StdID { get; set; }

    public int? Answer { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    [ForeignKey("QID")]
    public virtual Question Question { get; set; } = null!;

    [ForeignKey("StdID")]
    public virtual Student Student { get; set; } = null!;
}
