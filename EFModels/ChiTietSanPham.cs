namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSanPham")]
    public partial class ChiTietSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietSanPham()
        {
            CTSPDatHangs = new HashSet<CTSPDatHang>();
        }

        [Key]
        public int IDChitietSanPham { get; set; }

        public int IDSanPham { get; set; }

        public int IDKichCo { get; set; }

        public int IDMauSac { get; set; }

        public int? Soluong { get; set; }

        public virtual KichCo KichCo { get; set; }

        public virtual MauSac MauSac { get; set; }

        public virtual SanPham SanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTSPDatHang> CTSPDatHangs { get; set; }
    }
}
