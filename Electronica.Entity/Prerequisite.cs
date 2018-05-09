using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Prerequisite")]
    public class Prerequisite
    {
        [Key]
        public int PrerequisiteID { get; set; }

        [ForeignKey("EventIDNavigation")]
        public int EventID { get; set; }
        public Event EventIDNavigation { get; set; }

        public string FilePath { get; set; }
    }

}

