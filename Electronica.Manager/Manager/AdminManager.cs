
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
using Electronica.Repository;

namespace Electronica.Manager
{
    public class AdminManager
    {
        Admin admin = new Admin();
        AdminDAL adminDAL = new AdminDAL();
        public void InsertAdmin(AdminDTO adminDTO)
        {
            admin.AdminID = adminDTO.AdminID;
            admin.AdminName = adminDTO.AdminName;
            admin.AdminUserName = adminDTO.AdminUserName;
            admin.AdminPassword = adminDTO.AdminPassword;
            admin.AdminPhoneNumber = adminDTO.AdminPhoneNumber;
            adminDAL.InsertAdmin(admin);
        }

    }
}
