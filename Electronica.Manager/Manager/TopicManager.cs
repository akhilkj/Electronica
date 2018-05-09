using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Electronica.Entity;
using Electronica.Repository;

namespace Electronica.Manager
{
    public class TopicManager
    {
        Topic topic = new Topic();
        TopicDAL topicDAL = new TopicDAL();

        public void InsertTopic(TopicDTO topicDto)
        {
            topic.TopicID = topicDto.TopicID;
            topic.TopicName = topicDto.TopicName;
            topic.TopicCategory = topicDto.TopicCategory;
            topic.TopicSyllabus = topicDto.TopicSyllabus;
            topicDAL.InsertTopic(topic);
        }

        public List<TopicDTO> SelectTopic()
        {

            List<TopicDTO> topicDTOList = new List<TopicDTO>();
            List<Topic> topicList = topicDAL.SelectTopic();
            foreach (Topic item in topicList)
            {
                TopicDTO topicDTO = new TopicDTO();
                topicDTO.TopicID = item.TopicID;
                topicDTO.TopicName = item.TopicName;
                topicDTO.TopicCategory = item.TopicCategory;
                topicDTO.TopicSyllabus = item.TopicSyllabus;
                topicDTOList.Add(topicDTO);

            }

            return topicDTOList;
        }
        public List<TopicDTO> SelectTopicForEvent() //done by event
        {

            List<TopicDTO> topicDTOList = new List<TopicDTO>();
            List<Topic> topicList = topicDAL.SelectTopic();
            TopicDTO topicDTO;
            foreach (Topic item in topicList)
            {
               topicDTO = new TopicDTO();
                topicDTO.TopicID = item.TopicID;
                topicDTO.TopicName = item.TopicName;
                topicDTOList.Add(topicDTO);
            }

            return topicDTOList;
        }

    }
}
  

