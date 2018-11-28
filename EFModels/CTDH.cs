namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDH")]
    public partial class CTDH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTDH()
        {
            CTSPDatHangs = new HashSet<CTSPDatHang>();
        }

        [Key]
        public int IDCTDH { get; set; }

        public int IDDonHang { get; set; }

        public int IDCombo { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public double? ThanhTien { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual DonHang DonHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTSPDatHang> CTSPDatHangs { get; set; }
    }
}
