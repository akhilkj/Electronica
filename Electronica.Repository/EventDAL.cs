using Electronica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Repository
{
    public class EventDAL
    {
        ElectronicaContext electronicaContext;
        public EventDAL()
        {
            electronicaContext = new ElectronicaContext();

        }
        public int InsertEvent(Event newEvent)
        {
            int idOfAdmin = newEvent.EventCreatedBy;
            electronicaContext.Events.Add(newEvent);
            electronicaContext.SaveChanges();
            var eventID = ((from id in electronicaContext.Events
                          where id.EventCreatedBy == idOfAdmin
                           select id.EventID).ToArray()).Last();
            return eventID;
        }
        public List<Event> GetEvent()
        {
            List<Event> eventList = new List<Event>();
            var result = from temp in electronicaContext.Events
                        select temp;
            foreach (Event item in result)
            {
                eventList.Add(item);
            }
            return eventList;
        }
        public int[] SelectForEvent(DateTime startDate,DateTime endDate)
        {
            var eventIdList = (from temp in electronicaContext.Events where 
                                     ((startDate>=temp.EventStartDate && startDate<=temp.EventEndDate)||
                                     (endDate>=temp.EventStartDate && endDate<=temp.EventEndDate)||
                                     (startDate<temp.EventStartDate && endDate>temp.EventEndDate))
                                     select temp.EventID).ToArray();
            return eventIdList;
        }

        public int[] SelectForEventLocation(DateTime startDate,DateTime endDate)

        {
            //List<Location> listOfLocations = new List<Location>();
            var listLocation = (from temp in electronicaContext.Events
                                where
(((startDate >= temp.EventStartDate && startDate <= temp.EventEndDate) ||
(endDate >= temp.EventStartDate && endDate <= temp.EventEndDate) ||
(startDate < temp.EventStartDate && endDate > temp.EventEndDate))) select temp.LocationNavigation.LocationID).ToArray(); 


   //&& temp.LocationNavigation.LocationID != temp.LocationID)
   //                                select (temp.LocationNavigation)).ToList<Location>();
           
            return listLocation;               
        }
    }
}
