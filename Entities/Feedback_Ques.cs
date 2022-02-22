using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy_GCO.Entities
{
    public class Feedback_Ques
    {
        public int QueId { get; set; }
        public string Question { get; set; }
        public string Status { get; set; }
        public string CreatedOn { get; set; }
    }
}