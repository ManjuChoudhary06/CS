using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy_GCO.Entities
{
    public class Feedback_Ans
    {
        public int AnsId { get; set; }
        public int QueId { get; set; }
        public string Answer { get; set; }
        public int RegId { get; set; }
        public string FeedbackDate { get; set; }
    }
}