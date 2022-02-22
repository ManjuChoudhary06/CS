using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy_GCO.Entities
{
    public class CoursePayment
    {
        public int CourseId { get; set; }
        public int RegId { get; set; }

        public double  Amount { get; set; }
        public string ModeOfPayment { get; set; }
        public string PaidDate { get; set; }
    }
}