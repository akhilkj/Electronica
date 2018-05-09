using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Event")]
    public class Event
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventID { get; set; }
        
        public string EventName { get; set; }
      
        public DateTime EventStartDate { get; set; }
       
        public DateTime EventEndDate { get; set; }
      
        [ForeignKey("TopicNavigation")]
        public int TopicID { get; set; }
        public Topic TopicNavigation { get; set; }

       
        [ForeignKey("LocationNavigation")]
        
        public int LocationID { get; set; }
        public Location LocationNavigation { get; set; }
                
        
        public string PromoCode { get; set; }

        public DateTime PromoExpiry { get; set; }

        public int PromoDiscount { get; set; }

        [ForeignKey("SkillNavigation")]

        public int SkillID { get; set; }
        public Skill SkillNavigation { get; set; }


        public int EventFee { get; set; }
      
        public int EventIntake { get; set; }
       
        public int EventStatus { get; set; }
     
        public string EventDescription { get; set; }

        [ForeignKey("AdminNavigation")]
        public int EventCreatedBy { get; set; }
        public Admin AdminNavigation { get; set; }

        public int EventDeleteStatus { get; set; }
       
    }
}
