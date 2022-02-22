using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy_GCO.Entities
{
    public class CourseDetails
    {
        public int DetailsId { get; set; }
        public int Courseid { get; set; }
        public string VideoLink { get; set; }
        public string UploadedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Status { get; set; }

    }
}