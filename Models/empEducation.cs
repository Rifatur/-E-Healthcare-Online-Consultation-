namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empEducation")]
    public partial class empEducation
    {
        [Key]
        public int EmpEId { get; set; }

        [Required]
        [StringLength(20)]
        public string degreeName { get; set; }

        [StringLength(20)]
        public string startDate { get; set; }

        [StringLength(20)]
        public string EndDate { get; set; }

        [StringLength(150)]
        public string University { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        public int? EmpId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
