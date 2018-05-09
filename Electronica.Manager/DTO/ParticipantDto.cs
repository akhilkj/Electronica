using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electronica.Manager
{
    public class ParticipantDto
    {
        public int UserID { get; set; }
        [Required]
        [Display(Name ="Enter First Name")]
        [RegularExpression("^([A-z]+)$",ErrorMessage ="Only Alphabets allowed")]
        public string FirstName { get; set; }
        [Required]
        [Display( Name = "Enter Last Name")]
        [RegularExpression("^([A-z]+)$", ErrorMessage = "Only Alphabets allowed")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Enter Email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Enter a valid Email")]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        [Required]
        
        [RegularExpression("^([0-9]+)$", ErrorMessage = "Only numbers allowed")]
        public string Mobile { get; set; }

        [Display(Name = "Enter Qualification")]
        [Required]
        public string Education { get; set; }
        [Required]
        public string SelfDescription { get; set; }
        public byte[] ProfilePicture { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Retype Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="PASSWORD MISMATCH")]
        public string ConfirmPassword { get; set; }
    }
        
}
