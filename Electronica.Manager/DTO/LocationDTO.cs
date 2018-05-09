using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Electronica.Manager
{
    public class LocationDTO
    {
        [DisplayName("Location ID")]
        [ScaffoldColumn(false)]
        public int LocationID { get; set; }

        [Required(ErrorMessage = "Input the location Name ")]
        [DisplayName("Location Name")]
        public string LocationName { get; set; }

        [Required(ErrorMessage = "Input the Building Number ")]
        [DisplayName("Building Number")]
        public string LocationBuildingNumber { get; set; }

        [Required(ErrorMessage = "Input the City Name ")]
        [DisplayName("City")]
        public string LocationCity { get; set; }

        [Required(ErrorMessage = "Input the District Name ")]
        [DisplayName("District")]
        public string LocationDistrict { get; set; }

        [Required(ErrorMessage = "Input the State Name ")]
        [DisplayName("State")]
        public string LocationState { get; set; }

        
        [Required(ErrorMessage = "Input the Pin ")]
        [DisplayName("Pin Code")]
        public string LocationPinCode { get; set; }

        [Required(ErrorMessage = "Input the Landmark Name ")]
        [DisplayName("Landmark")]
        public string LocationLandMark { get; set; }

        [Required(ErrorMessage = "Input the Seat Capacity ")]
        [DisplayName("Seat Capacity")]
        public int LocationSeatingCapacity { get; set; }

        [Required(ErrorMessage = "Input the AC Availability ")]
        [DisplayName("AC Availability")]
        public int LocationAC { get; set; }

        [Required(ErrorMessage = "Input the Location Status")]
        [DisplayName("Location Status")]
        public int LocationStatus { get; set; }


        [Required(ErrorMessage = "Input the Location Image")]
        [DisplayName("Location Image")]
        public string LocationImage { get; set; }
    }
}
