using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
  public  class SpeakerSkillMapDAL
    {
        ElectronicaContext context;
        public SpeakerSkillMapDAL()
        {
            context = new ElectronicaContext();
        }
        public void InsertSpeakerSkillMap(SpeakerSkillMap speakerSkillMap)
        {
            context.SpeakerSkillMaps.Add(speakerSkillMap);
            context.SaveChanges();
        }
        public void DeleteSpeakerSkillMap(int id)
        {
            SpeakerSkillMap speakerskillmap = new SpeakerSkillMap();
            speakerskillmap = context.SpeakerSkillMaps.Find(id);
            //speakerskillmap.DeleteStatus = true;
            context.SaveChanges();
        }

        public void UpdateSpeakerSkillMap(SpeakerSkillMap speakerSkillMap, int id)
        {
            SpeakerSkillMap speakerskillmapobj = new SpeakerSkillMap();
            speakerskillmapobj = context.SpeakerSkillMaps.Find(id);
            speakerskillmapobj.SpeakerSkillMapID = speakerSkillMap.SpeakerSkillMapID;
            speakerskillmapobj.SkillID = speakerSkillMap.SkillID;
            speakerskillmapobj.UserID = speakerSkillMap.UserID;
            speakerskillmapobj.SpeakerSkillRating = speakerSkillMap.SpeakerSkillRating;
            //speakerskillmapobj.DeleteStatus = speakerSkillMap.DeleteStatus;            
            context.SaveChanges();
        }
        public int[] SelectSpeakerForEvent(int skillID) // admin
        {
            var UserID = (from user in context.SpeakerSkillMaps
                         where user.SkillID == skillID && user.SpeakerSkillRating>=3
                         select user.UserID).ToArray();
            return UserID;
        }
    }
}
