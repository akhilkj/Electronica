using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Repository;
using Electronica.Entity;
using Electronica.Manager.DTO;

namespace Electronica.Manager
{
    public class EventManager
    {
        List<ParticipantDto> speakerlist = new List<ParticipantDto>();
      static  List<User> speakerList = new List<User>();

        public bool CreateEvent(EventDTO eventManager)
        {
            Electronica.Entity.Event eventObject = new Event();
            Electronica.Repository.EventDAL eventDALObject = new EventDAL();
            
            eventObject.EventName = eventManager.EventName;
            eventObject.EventStartDate = eventManager.EventStartDate;
            eventObject.EventEndDate = eventManager.EventEndDate;
            eventObject.TopicID = eventManager.TopicID;
            eventObject.LocationID = eventManager.LocationID;
            eventObject.PromoCode = eventManager.PromoCode;
            eventObject.PromoDiscount = eventManager.PromoDiscount;
            eventObject.PromoExpiry = eventManager.PromoExpiry;
            eventObject.EventFee = eventManager.EventFee;
            eventObject.EventIntake = eventManager.EventIntake;
            eventObject.EventStatus =1;//upcoming
            eventObject.EventCreatedBy = 1;//eventManager.EventCreatedBy;
            eventObject.EventDeleteStatus = 0;//not deleted
            eventObject.EventDescription = eventManager.EventDescription;
            int eventID=eventDALObject.InsertEvent(eventObject);//insertion into eventtable
            SpeakerEnrollmentDAL speakerEnrollmentDALObject = new SpeakerEnrollmentDAL();
            SpeakerEnrollment speakerEnrollmentObject = new SpeakerEnrollment();
            speakerEnrollmentObject.EventID = eventID;
            speakerEnrollmentObject.UserID = eventManager.SpeakerID;
            speakerEnrollmentDALObject.InsertSpeakerEnrollment(speakerEnrollmentObject); //insertion to speaker enrollment table
            return true;
        }
        public List<EventDTO> SearchEvent()
        {
            
            EventDTO eventDtoObject;       //creating EventDTO object
            List<EventDTO> eventDto = new List<EventDTO>();
            List<Event> eventList = new List<Event>();
            EventDAL eventDalObject = new EventDAL();
            eventList = eventDalObject.GetEvent();
            int lengthList = eventList.Count;
            for (int i = 0; i < lengthList; i++)
            {
                eventDtoObject = new EventDTO();
                eventDtoObject.EventCreatedBy = eventList[i].EventCreatedBy;
                eventDtoObject.EventID = eventList[i].EventID;
                eventDtoObject.EventDescription = eventList[i].EventDescription;
                eventDtoObject.EventEndDate = eventList[i].EventEndDate;
                eventDtoObject.EventFee = eventList[i].EventFee;
                eventDtoObject.EventIntake = eventList[i].EventIntake;
                eventDtoObject.EventName = eventList[i].EventName;
                eventDtoObject.EventStartDate = eventList[i].EventStartDate;



                eventDtoObject.EventStatus = eventList[i].EventStatus;
                eventDtoObject.LocationID = eventList[i].LocationID;
                eventDtoObject.TopicID = eventList[i].TopicID;

                //enrollment id should be added
                eventDtoObject.PromoCode = eventList[i].PromoCode;
                eventDtoObject.PromoDiscount = eventList[i].PromoDiscount;
                eventDtoObject.PromoExpiry = eventList[i].PromoExpiry;
                eventDto.Add(eventDtoObject);
                
            }
            return eventDto;


        }



     //   public string UpdateEventStatus(int eventid)
       // {


        //}
        
        public void AfterDateSelect(DateTime startDate, DateTime endDate, int SkillID)
        {
            speakerList = new List<User>();
            SpeakerSkillMapDAL speakerSkillMap = new SpeakerSkillMapDAL();
            EventDAL eventObject = new EventDAL();
            UserDAL userObject = new UserDAL();
            EnrollmentDal enrollmentObject = new EnrollmentDal();
            SpeakerEnrollmentDAL speakerEnrollmentObject = new SpeakerEnrollmentDAL();
            List<User> speakerListTemp;
            List<User> speakerListTemp2;

            speakerListTemp = userObject.UserForSelect();
            int[] skilledUserID = speakerSkillMap.SelectSpeakerForEvent(SkillID);
            int[] eventList = eventObject.SelectForEvent(startDate, endDate);
            List<SpeakerEnrollment> enrolledSpeakers = speakerEnrollmentObject.SpeakerForSelect(eventList);
            List<ParticipantEnrollment> enrolledParticipants = enrollmentObject.ParticipantForSelect(eventList);
            int skilledLength = skilledUserID.Length;
            for(int i=0;i<skilledLength;i++)
            {
                speakerListTemp2 = speakerListTemp.Where(s => s.UserID == skilledUserID[i]).ToList<User>();
                speakerList.AddRange(speakerListTemp2);
            }
            int enrolledSpeakerLength = enrolledSpeakers.Count();
            for (int i = 0; i < enrolledSpeakerLength; i++)
            {
                speakerList = speakerList.Where(s => s.UserID != enrolledSpeakers[i].UserID).ToList<User>();
            }
            int enrolledParticipanLength = enrolledParticipants.Count();
            for (int i = 0; i < enrolledParticipanLength; i++)
            {
                if ((speakerList.Find(s => s.UserID == enrolledParticipants[i].UserID)) != null)
                {
                    speakerList = speakerList.Where(s => s.UserID != enrolledParticipants[i].UserID).ToList<User>();
                }
            }




        //    int k=   speakerlist.Count();

        }
        public List<ParticipantDto> ConvertToList()
            {
             ParticipantDto speaker;
            foreach (var item in speakerList)
            {
                speaker = new ParticipantDto();
                speaker.UserID = item.UserID;
                speaker.FirstName = item.FirstName + " " + item.LastName;
                speakerlist.Add(speaker);
            }
            return speakerlist;
            }




        static List<LocationDTO> locationListForSelect;
        public void AfterDateSelectForLocation(DateTime startDate,DateTime endDate)
        {
            locationListForSelect= new List<LocationDTO>();
            EventDAL locationObject = new EventDAL();
            LocationDTO locationDtoObject = new LocationDTO();
            LocationDAL locationDALObject = new LocationDAL();
            List<Location> locationList = locationDALObject.SelectLocation();
           int[] collidingLocationID =locationObject.SelectForEventLocation(startDate, endDate);
            int collidingLocationIDLength = collidingLocationID.Length;
            for(int i=0;i<collidingLocationIDLength;i++)
            {
                locationList = locationList.Where(w => w.LocationID != collidingLocationID[i]).ToList<Location>();
            }




           foreach (var item in locationList)
            {
                locationDtoObject = new LocationDTO();
                locationDtoObject.LocationID = item.LocationID;
                locationDtoObject.LocationName = item.LocationName;
                locationListForSelect.Add(locationDtoObject);
            }
        }


        public List<LocationDTO> GetAllLocations()
        {
            LocationManager locationManger = new LocationManager();
            List<LocationDTO> allLocations = new List<LocationDTO>();
            allLocations = locationManger.SelectLocation();
            return allLocations;
        }






        public List<LocationDTO> LocationConverstionToList()
        {
            return locationListForSelect;
        }
    }
}
