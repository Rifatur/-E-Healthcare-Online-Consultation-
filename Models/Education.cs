namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Education")]
    public partial class Education
    {
        [Key]
        public int EId { get; set; }

        [Required]
        [StringLength(20)]
        public string DegreeName { get; set; }

        [StringLength(20)]
        public string StartDate { get; set; }

        [StringLength(20)]
        public string EndDate { get; set; }

        [StringLength(150)]
        public string University { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        public int? DocId { get; set; }

        public virtual Doctortbl Doctortbl { get; set; }
    }
}
