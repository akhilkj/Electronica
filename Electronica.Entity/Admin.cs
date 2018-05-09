using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }

          

        public string AdminUserName { get; set; }

          

        public string AdminPassword { get; set; }

          

        public string AdminName { get; set; }

          

        public string AdminPhoneNumber { get; set; }

          
        public string AdminEmailID { get; set; }
    }
}
