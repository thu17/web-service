namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("khachhang")]
    public partial class khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khachhang()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        public int IDkhachhang { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        [Required]
        [StringLength(15)]
        public string Sdt { get; set; }

        [Required]
        [StringLength(50)]
        public string Diachi { get; set; }

        public int? Loaikhachhang { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
