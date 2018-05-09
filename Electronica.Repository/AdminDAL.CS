
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
    public class AdminDAL
    {
        ElectronicaContext electronicaContext;
        public AdminDAL()
        {
            electronicaContext = new ElectronicaContext();

        }
        public bool InsertAdmin(Admin admin)
        {
            electronicaContext.Admins.Add(admin);
            electronicaContext.SaveChanges();
            return true;
        }
        public List<Admin> selectAdmin()
        {
            List<Admin> adminList = new List<Admin>();
            var admins = from tempAdmins in electronicaContext.Admins
                         select tempAdmins;
            foreach (Admin item in admins)
            {
                adminList.Add(item);
            }
            return adminList;
        }
    }
}

