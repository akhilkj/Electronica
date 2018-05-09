using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
using Electronica.Repository;

namespace Electronica.Manager
{
    public class LocationManager
    {
        
        LocationDAL locationDal = new LocationDAL();
        Location location = new Location();
        LocationDTO locationDto = new LocationDTO();
        public bool AddLocation(LocationDTO locationDto)
        {            
            location.LocationName = locationDto.LocationName;
            location.LocationBuildingNumber = locationDto.LocationBuildingNumber;
            location.LocationCity = locationDto.LocationCity;
            location.LocationDistrict = locationDto.LocationDistrict;
            location.LocationState = locationDto.LocationState;
            location.LocationPin = locationDto.LocationPinCode;
            location.LocationLandMark = locationDto.LocationLandMark;
            location.LocationSeatingCapacity = locationDto.LocationSeatingCapacity;
            location.LocationAc = locationDto.LocationAC;
            location.LocationStatus = locationDto.LocationStatus;
            location.LocationImage = locationDto.LocationImage;

            locationDal.InsertLocation(location);
            
            return true;
        }
        public List<LocationDTO> SelectLocation()
        {
            List<LocationDTO> locationDtoList = new List<LocationDTO>();
            List<Location> locationList = locationDal.SelectLocation();
            foreach (var item in locationList)
            {
                locationDto.LocationID = item.LocationID;
                locationDto.LocationName = item.LocationName;
                locationDto.LocationBuildingNumber = item.LocationBuildingNumber;
                locationDto.LocationCity = item.LocationCity;
                locationDto.LocationDistrict = item.LocationDistrict;
                locationDto.LocationState = item.LocationState;
                locationDto.LocationPinCode = item.LocationPin;
                locationDto.LocationLandMark = item.LocationLandMark;
                locationDto.LocationSeatingCapacity = item.LocationSeatingCapacity;
                locationDto.LocationAC = item.LocationAc;
                locationDto.LocationStatus = item.LocationStatus;
                locationDto.LocationImage = item.LocationImage;
                

                locationDtoList.Add(locationDto);
            }
            return locationDtoList ;
        }
       
    }
}
