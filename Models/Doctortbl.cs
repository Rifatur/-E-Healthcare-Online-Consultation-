namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctortbl")]
    public partial class Doctortbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctortbl()
        {
            Appointments = new HashSet<Appointment>();
            Educations = new HashSet<Education>();
            Specializations = new HashSet<Specialization>();
        }

        [Key]
        public int DocId { get; set; }

        [Required]
        [StringLength(100)]
        public string FName { get; set; }

        [Required]
        [StringLength(100)]
        public string LName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Passward { get; set; }

        [StringLength(50)]
        public string DOB { get; set; }

        public string DoctorImage { get; set; }

        [StringLength(20)]
        public string Gander { get; set; }

        [StringLength(200)]
        public string DocAddress { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(20)]
        public string Post { get; set; }

        public int? PhoneNo { get; set; }

        public int? DepartmentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Education> Educations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialization> Specializations { get; set; }
    }
}
