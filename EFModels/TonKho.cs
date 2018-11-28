namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TonKho")]
    public partial class TonKho
    {
        [Key]
        public int IDTonKho { get; set; }

        public int IDSanPham { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuong { get; set; }

        public double? GiaNhap { get; set; }

        public double? GiaBan { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
