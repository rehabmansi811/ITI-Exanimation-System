using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desktop.Models;

public partial class Topic
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public int CrsID { get; set; }

    [ForeignKey("CrsID")]
    public virtual Course Course { get; set; } = null!;
}
