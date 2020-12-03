namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            empEducations = new HashSet<empEducation>();
        }

        [Key]
        public int EmpId { get; set; }

        [Required]
        [StringLength(100)]
        public string EmpFName { get; set; }

        [Required]
        [StringLength(100)]
        public string EmpLName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Passward { get; set; }

        [StringLength(20)]
        public string DOB { get; set; }

        public string EmpImage { get; set; }

        [StringLength(20)]
        public string Gander { get; set; }

        [StringLength(200)]
        public string EmpAddress { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(20)]
        public string Post { get; set; }

        public int? PhoneNo { get; set; }

        public int? eTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empEducation> empEducations { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
    }
}
