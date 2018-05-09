using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Manager;
using Electronica.Manager.DTO;


namespace Electronica.MVC.Controllers
{
    public class EventController : Controller
    {


        public ActionResult AddEvent()
        {

          
            return View();
        }
        [HttpPost]
        public ActionResult AddEvent(EventDTO eventDto)
        {
            if (ModelState.IsValid)
            {
                EventManager eventManager = new EventManager();
                eventManager.CreateEvent(eventDto);       //calling fn
            }
            return View();
        }
        // GET: Event
        public JsonResult TopicJson()
        {
            List<TopicDTO> topicList = new List<TopicDTO>();
            TopicManager topicManager = new TopicManager();

            topicList = topicManager.SelectTopicForEvent();
            return Json(topicList, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public void SelectLocationForSpeaker(DateTime StartDate, DateTime EndDate)
        {

            EventManager eventObject = new EventManager();
            eventObject.AfterDateSelectForLocation(StartDate, EndDate);

        }


        public JsonResult LocationJson()
        {
            List<LocationDTO> locationList = new List<LocationDTO>();
            EventManager eventManager = new EventManager();
            locationList = eventManager.LocationConverstionToList();
            return Json(locationList, JsonRequestBehavior.AllowGet);
           // return;
         }

        public JsonResult GetAllLocations()
        {
            List<LocationDTO> locationList = new List<LocationDTO>();
            EventManager eventManger = new EventManager();
            locationList = eventManger.GetAllLocations();
            return Json(locationList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SkillJson()
        {
            List<Skill> skillList = new List<Skill>();
            SkillManager skillManager = new Manager.SkillManager();
            skillList = skillManager.SelectSkillsForEvent();
            return Json(skillList, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public void SelectForSpeaker(DateTime StartDate, DateTime EndDate, int SkillID)
        {

            EventManager eventObject = new EventManager();
            eventObject.AfterDateSelect(StartDate, EndDate, SkillID);

        }
        public JsonResult SpeakerJson()
        {
          
            EventManager eventManager = new EventManager();
            List<ParticipantDto> speakerList = eventManager.ConvertToList();
            
            return Json(speakerList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SearchEvent()
        {
            EventManager eventmanager = new EventManager();
            List<EventDTO> eventList = new List<EventDTO>();
            eventList = eventmanager.SearchEvent();
            return Json(eventList,JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewEvents()
        {
            return View();
        }
       


       
    }

}