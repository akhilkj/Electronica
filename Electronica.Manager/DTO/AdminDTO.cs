using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Manager
{
    public class AdminDTO
    {
        
        [ScaffoldColumn(false)]
        public int AdminID { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string AdminUserName { get; set; }

        [Required]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z])")]
        public string AdminPassword { get; set; }

        [Compare("AdminPassword")]
        public string ConfirmAdminPassword { get; set; }


        [Required]
        public string AdminPhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string AdminEmailID { get; set; }


    }
}