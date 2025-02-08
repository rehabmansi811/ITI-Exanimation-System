using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    public class Std_Crs
    {
        public int StdID { get; set; }

        public int CrsID { get; set; }

        [ForeignKey("CrsID")]
        public virtual Course Course { get; set; } = null!;

        [ForeignKey("StdID")]
        public virtual Student Student { get; set; } = null!;
    }
}
