using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("SpeakerSkillMap")]
    public class SpeakerSkillMap
    {
        [Key]
        public int SpeakerSkillMapID { get; set; }
        [ForeignKey("SkillNavigation")]
        public int SkillID { get; set; }
        public Skill SkillNavigation { get; set; }

        [ForeignKey("SpeakerNavigation")]
        public int UserID { get; set; }
        public User SpeakerNavigation { get; set; }
        public int SpeakerSkillRating { get; set; }



    }
}

