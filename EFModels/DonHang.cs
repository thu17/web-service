namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            CTDHs = new HashSet<CTDH>();
        }

        [Key]
        public int IDDonHang { get; set; }

        public int IDKhachHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }

        public double? TongGia { get; set; }

        public double? PhiVanChuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDH> CTDHs { get; set; }

        public virtual khachhang khachhang { get; set; }
    }
}
