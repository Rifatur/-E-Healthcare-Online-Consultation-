namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            patients = new HashSet<patient>();
        }

        [Key]
        public int AId { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [StringLength(100)]
        public string LName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(500)]
        public string State { get; set; }

        [StringLength(20)]
        public string SerialNo { get; set; }

        public int? DepartmentId { get; set; }

        public int? DocId { get; set; }

        [StringLength(10)]
        public string set_time { get; set; }

        [Column(TypeName = "date")]
        public DateTime? APM_Date { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        public int? Age { get; set; }

        public int? contactNo { get; set; }

        [StringLength(300)]
        public string Message { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public virtual Department Department { get; set; }

        public virtual Doctortbl Doctortbl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patient> patients { get; set; }
    }
}
