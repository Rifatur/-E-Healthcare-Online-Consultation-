using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class SpecializationModel
    {
        public int SpecializationID { get; set; }
        public string SpecName { get; set; }
        public string SpecImage { get; set; }
        public int? DocId { get; set; }
    }
}