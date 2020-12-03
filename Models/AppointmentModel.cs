using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class AppointmentModel
    {
        public int AId { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string SerialNo { get; set; }
        public int? DepartmentId { get; set; }
        public string DName { get; set; }
        public int? DocId { get; set; }
        public string set_time { get; set; } 
        public DateTime? APM_Date { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public int? contactNo { get; set; }
        public string Message { get; set; }

        public AppointmentModel()
        {
            this.CreatedDate = Date.Now;
        }
        public DateTime? CreatedDate { get; set; }
    }
}