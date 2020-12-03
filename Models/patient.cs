namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class patient
    {
        [Key]
        public int Pid { get; set; }

        [Required]
        [StringLength(30)]
        public string Diseases { get; set; }

        [StringLength(30)]
        public string MaritalStatus { get; set; }

        [StringLength(30)]
        public string BloodGroup { get; set; }

        [StringLength(30)]
        public string BloodPresure { get; set; }

        [StringLength(30)]
        public string Sugger { get; set; }

        [StringLength(30)]
        public string Injury { get; set; }

        [StringLength(30)]
        public string RoomNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfAdmit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DischargeDate { get; set; }

        public int? AId { get; set; }

        public virtual Appointment Appointment { get; set; }
    }
}
