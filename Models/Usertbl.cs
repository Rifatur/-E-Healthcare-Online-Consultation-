namespace Hoyna.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usertbl")]
    public partial class Usertbl
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public string UserImage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? createdDate { get; set; }

        public int? Status { get; set; }
    }
}
