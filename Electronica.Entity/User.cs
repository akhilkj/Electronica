using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electronica.Entity
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column(Order = 1)]
        public int UserID { get; set; }

        [ForeignKey("UserTypeNavigation")]
        public int UserTypeID { get; set; }
        public UserType UserTypeNavigation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Education { get; set; }
        public string Mobile { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public string SelfDescription { get; set; }

    }
}

