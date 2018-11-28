namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietComboes = new HashSet<ChiTietCombo>();
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
            SanPham_DacDiem = new HashSet<SanPham_DacDiem>();
            TonKhoes = new HashSet<TonKho>();
        }

        [Key]
        public int IDSanPham { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        public double? GiaBan { get; set; }

        public int? SoLuongTong { get; set; }

        [StringLength(500)]
        public string URLAnh { get; set; }

        public int IDThuongHieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietCombo> ChiTietComboes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham_DacDiem> SanPham_DacDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TonKho> TonKhoes { get; set; }
    }
}
