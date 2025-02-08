using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop.Models;

public partial class Choice
{
    public int QID { get; set; }

    public int ChoiceNum { get; set; }

    public string Body { get; set; }

    [ForeignKey("QID")]
    public virtual Question Question { get; set; } = null!;
}
