using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy_GCO.Entities
{
    public class Course
    {
        public int CousreId { get; set; }

        public string  CourseName { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string CourseType { get; set; }
        public string Status { get; set; }

        public double Price { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }



    }
}