using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy_GCO.Entities
{
    public class CourseRegistration
    {
        public int CourseRegId { get; set; }
        public int CourseId { get; set; }
        public int RegId { get; set; }

        public string Status { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string CourseRegistrationDate { get; set; }
        //[Required(ErrorMessage = "Enter the issued date.")]
        //[DataType(DataType.Date)]
        //public DateTime IssueDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
        //       ApplyFormatInEditMode = true)]
        //public DateTime DeliveredDate { get; set; }
    }
}