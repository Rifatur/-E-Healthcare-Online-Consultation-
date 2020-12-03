using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }
        public string DName { get; set; }
        public string DImage { get; set; }
        public string Discription { get; set; }
        public DepartmentModel()
        {
            this.createdDate = Date.Now;
        }
        public DateTime? createdDate { get; set; }
    }
}