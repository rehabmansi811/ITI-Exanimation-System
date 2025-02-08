using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class Department
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public string? Describe { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
