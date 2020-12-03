namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Specialization")]
    public partial class Specialization
    {
        public int SpecializationID { get; set; }

        [StringLength(100)]
        public string SpecName { get; set; }

        public string SpecImage { get; set; }

        public int? DocId { get; set; }

        public virtual Doctortbl Doctortbl { get; set; }
    }
}
