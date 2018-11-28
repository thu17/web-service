namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admin")]
    public partial class admin
    {
        [Key]
        public int IDAdmin { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        [Required]
        [StringLength(15)]
        public string Sdt { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string CMND { get; set; }
    }
}
