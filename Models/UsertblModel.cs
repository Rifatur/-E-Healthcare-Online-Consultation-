using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hoyna.Models
{
    public class UsertblModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserImage { get; set; }

        public UsertblModel()
        {
            this.createdDate = Date.Now;
        }
        public DateTime? createdDate { get; set; }
        public int? Status { get; set; }

    }
}