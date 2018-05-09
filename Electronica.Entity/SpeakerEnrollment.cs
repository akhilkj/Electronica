using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("SpeakerEnrollment")]
    public class SpeakerEnrollment
    {
        [Key]
        public int SpeakerEnrollmentID { get; set; }

        [ForeignKey("EventNavigation")]
        public int EventID { get; set; }
        public Event EventNavigation { get; set; }

        [ForeignKey("UserNavigation")]
        public int UserID { get; set; }
        public User UserNavigation { get; set; }

    }
}

