using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Data.Entity;


namespace Electronica.Entity
{
    [Table("ParticipantEnrollment")]
    public class ParticipantEnrollment
    {
        [Key]
        [Column(Order = 1)]
        public int ParticipantEnrollmentID { get; set; }
        [Column(Order = 2)]
        [ForeignKey("EventNavigation")]

        public int EventID { get; set; }
        public Event EventNavigation { get; set; }

        [Column(Order = 3)]
        [ForeignKey("UserNavigation")]
        //public string Email { get; set; }
        public int UserID { get; set; }
        public User UserNavigation { get; set; }

        [Column(Order = 4)]
        public Boolean PaymentStatus { get; set; }

        [Column(Order = 5)]
        public int PresentationSkill { get; set; }

        [Column(Order = 6)]
        public int TrainingSkill { get; set; }

        [Column(Order = 7)]
        public int SubjectKnowledge { get; set; }

        [Column(Order = 8)]
        public int TrainingContent { get; set; }

        [Column(Order = 9)]
        public int InteractionSkill { get; set; }

        [Column(Order = 10)]
        public string Comments { get; set; }
    }
}

