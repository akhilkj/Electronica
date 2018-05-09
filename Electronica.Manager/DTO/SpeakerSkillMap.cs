using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Manager.ElectronicaDTO

{
    public class SpeakerSkillMap
    {
        [ScaffoldColumn(false)]
        public int SpeakerSkillMapID { get; set; }
        [Required]
        public int Rating { get; set; }
        public int UserID { get; set; }
        [Required]
        public int SkillID { get; set; }

    }
}
