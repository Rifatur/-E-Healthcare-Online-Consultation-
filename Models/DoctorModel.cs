using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class DoctorModel
    {
        public int DocId { get; set; }
        public string FName { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }

        public string Passward { get; set; }

        public string DOB { get; set; }

        public string DoctorImage { get; set; }

        public string Gander { get; set; }

        public string DocAddress { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Post { get; set; }

        public int? PhoneNo { get; set; }

        public int? DepartmentId { get; set; }
        public string DName { get; set; }
        public DoctorModel()
        {
            this.CreatedDate = Date.Now;
        }
        public DateTime? CreatedDate { get; set; }

    }
}