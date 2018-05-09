using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
using Electronica.Repository;
using System.ComponentModel.DataAnnotations;

namespace Electronica.Manager
{
    public class TopicDTO
    {

        [ScaffoldColumn(false)]
        public int TopicID { get; set; }
        [Required(ErrorMessage = ("Topic name is required"))]
        [Display(Name = "Topic Name")]
        public string TopicName { get; set; }
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public string TopicCategory { get; set; }
        [Required(ErrorMessage = "syllabus")]
        [Display(Name = "syllabus")]
        public string TopicSyllabus { get; set; }
        [ScaffoldColumn(false)]

        public int TopicDeleteStatus { get; set; }
    }
}
