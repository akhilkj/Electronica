using Electronica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Repository
{
 public   class SpeakerEnrollmentDAL
    {
        ElectronicaContext electronicaContext;
        public SpeakerEnrollmentDAL()
        {
            electronicaContext = new ElectronicaContext();
        }
        public bool InsertSpeakerEnrollment(SpeakerEnrollment speakerEnrollment)
        {
            electronicaContext.SpeakerEnrollments.Add(speakerEnrollment);
            electronicaContext.SaveChanges();
            return true;
        }
        public List<SpeakerEnrollment> SpeakerForSelect(int[] eventID)
        {
          
                int eventIDLength = eventID.Length;
                List<SpeakerEnrollment> speakerList = new List<SpeakerEnrollment>();
                for (int i = 0; i < eventIDLength; i++)
                {
                int eventIDLinq = eventID[i];
                    var speaker = (from temp in electronicaContext.SpeakerEnrollments 
                                          where temp.EventID == eventIDLinq
                                          select temp);
                    foreach (var item in speaker)
                    {
                        speakerList.Add(item);

                    }

                }

                return speakerList;
            
        }

    }
}
