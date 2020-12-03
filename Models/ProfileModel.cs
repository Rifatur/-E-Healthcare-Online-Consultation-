using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class ProfileModel
    {

        public Doctortbl doctordetails { get; set; }
        public Education edudetails { get; set; }
        public Specialization SpecDetails { get; set; }
    }
}