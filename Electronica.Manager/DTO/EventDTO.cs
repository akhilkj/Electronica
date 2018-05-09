using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Manager.DTO
{
    public class EventDTO
    {
        [ScaffoldColumn(false)]
        public int EventID { get; set; }//hiddenfor
        [Required]
        public string EventName { get; set; }
        [Required]
        public DateTime EventStartDate { get; set; }
        [Required]
        public DateTime EventEndDate { get; set; }
        [Required]
        public int TopicID { get; set; }
        [Required]
        public int LocationID { get; set; }
        [Required]
        public int SkillID { get; set; } //For skill
        [Required]
        public int SpeakerID { get; set; }
       

        [Required]
        public string PromoCode { get; set; }
        [Required]
        public DateTime PromoExpiry { get; set; }
        [Required]
        public int PromoDiscount { get; set; }
        [Required]
        public int EventFee { get; set; }
        [Required]
        public int EventIntake { get; set; }
        [Required]
        public int EventStatus { get; set; }
        [Required]
        public string EventDescription { get; set; }
        [Required]
        public int EventCreatedBy { get; set; }

    }
}
