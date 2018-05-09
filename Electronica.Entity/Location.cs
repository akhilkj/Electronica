using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Location") ]
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int LocationID { get; set; }
          
        public string LocationName { get; set; }
          
        public string LocationBuildingNumber { get; set; }
          
        public string LocationCity { get; set; }
          
        public string LocationDistrict { get; set; }
          
        public string LocationState { get; set; }
          
        public string LocationPin { get; set; }
          
        public string LocationLandMark { get; set; }
          
        public int LocationSeatingCapacity { get; set; }
          
        public int LocationAc { get; set; }
          
        public int LocationStatus { get; set; }
          
        public string LocationImage { get; set; }
          
    }

}

