namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTSPDatHang")]
    public partial class CTSPDatHang
    {
        [Key]
        public int IDCTSPDatHang { get; set; }

        public int IDCTDH { get; set; }

        public int IDChiTietSanPham { get; set; }

        public virtual ChiTietSanPham ChiTietSanPham { get; set; }

        public virtual CTDH CTDH { get; set; }
    }
}
