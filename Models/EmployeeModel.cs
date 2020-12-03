using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }

        public string EmpFName { get; set; }

        public string EmpLName { get; set; }

        public string Email { get; set; }

        public string Passward { get; set; }

        public string DOB { get; set; }

        public string EmpImage { get; set; }

        public string Gander { get; set; }
        public string EmpAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Post { get; set; }

        public int? PhoneNo { get; set; }
        public int? eTypeId { get; set; }
        public string eTypeName { get; set; }
        public EmployeeModel()
        {
            this.CreatedDate = Date.Now;
        }
        public DateTime? CreatedDate { get; set; }
    }
}