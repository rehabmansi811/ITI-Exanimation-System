using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class Intake
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
