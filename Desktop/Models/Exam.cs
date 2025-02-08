using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop.Models;

public partial class Exam
{
    public int ID { get; set; }

    public string? Name { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int CrsID { get; set; }

    public virtual ICollection<Answer_Exam> Answers { get; set; } = new List<Answer_Exam>();

    [ForeignKey("CrsID")]
    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<Student_Exam> Students { get; set; } = new List<Student_Exam>();
}
