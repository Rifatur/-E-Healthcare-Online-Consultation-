namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Appointments = new HashSet<Appointment>();
            Doctortbls = new HashSet<Doctortbl>();
        }

        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string DName { get; set; }

        public string DImage { get; set; }

        [StringLength(500)]
        public string Discription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctortbl> Doctortbls { get; set; }
    }
}
