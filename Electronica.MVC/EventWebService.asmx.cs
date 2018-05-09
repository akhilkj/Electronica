using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using Electronica.Manager.DTO;
using System.Web.Mvc;

namespace Electronica.MVC
{
    /// <summary>
    /// Summary description for EventWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class EventWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetEvents()
        {
            List<EventDTO> eventDto = new List<EventDTO>(); 
            string connectionString = ConfigurationManager.ConnectionStrings["ElectronicaDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetEvents", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EventDTO eventDtoObject = new EventDTO()
                    {
                        EventID = Convert.ToInt32(rdr["Event ID"]),
                        EventName = rdr["Event Name"].ToString(),
                        EventStartDate = Convert.ToDateTime(rdr["Start Date"])
                    };
                    eventDto.Add(eventDtoObject);

                }   
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Write(js.Serialize(eventDto));
            }
        }
    }
}
