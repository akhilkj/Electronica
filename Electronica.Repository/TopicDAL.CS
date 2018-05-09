
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Repository
{
    public class TopicDAL
    {
        ElectronicaContext electronicaContext;
        public TopicDAL()
        {

            electronicaContext = new ElectronicaContext();
        }
        public bool InsertTopic(Topic topic)
        {
            electronicaContext.Topics.Add(topic);
            electronicaContext.SaveChanges();
            return true;
        }

        public List<Topic> SelectTopic()
        {
            List<Topic> TopicList = new List<Topic>();
            var topics = from tempTopic in electronicaContext.Topics
                         select tempTopic;
            foreach (Topic item in topics)
            {
                TopicList.Add(item);
            }
            return TopicList;
        }
    }
}
