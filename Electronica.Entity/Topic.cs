using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Topic")]
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TopicID { get; set; }
        
        public string TopicName { get; set; }
        
        public string TopicCategory { get; set; }
 
        public string TopicSyllabus { get; set; }
        

    }
}
