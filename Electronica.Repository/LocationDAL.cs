using Electronica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Repository
{
    public class LocationDAL
    {
        ElectronicaContext electronicaContext;
        public LocationDAL()
        {
            electronicaContext = new ElectronicaContext();
        }
        public bool InsertLocation(Location location)
        {
            electronicaContext.Locations.Add(location);
            electronicaContext.SaveChanges();
            return true;
        }
        public List<Location> SelectLocation()
        {
            List<Location> locationList = new List<Location>();
            var locationVariable = from locations in electronicaContext.Locations select locations;//linq
            foreach ( var item in locationVariable)
            {
                locationList.Add(item);
            }
            return locationList;
        }
    }
}
