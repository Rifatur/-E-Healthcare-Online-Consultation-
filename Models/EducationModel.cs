using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class EducationModel
    {
        public int EId { get; set; }
        public string DegreeName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string University { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int? DocId { get; set; }


    }
}