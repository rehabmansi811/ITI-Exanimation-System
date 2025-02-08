using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop.Models;

public partial class Person
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string NID { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Gender { get; set; }

    public decimal? Salary { get; set; }

    public DateOnly? DOB { get; set; }

    public string? Phone { get; set; }

    public string Role { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? DeptID { get; set; }

    [ForeignKey("DeptID")]
    public virtual Department? Department { get; set; }

    public virtual Instructor? Instructor { get; set; }

    public virtual Student? Student { get; set; }
}
