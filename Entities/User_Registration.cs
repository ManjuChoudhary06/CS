using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy_GCO.Entities
{
    public class User_Registration
    {
        public int RegId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }

        public string ContactNo { get; set; }

        public string BirthDate { get; set; }
    }
}