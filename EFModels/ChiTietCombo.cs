namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietCombo")]
    public partial class ChiTietCombo
    {
        [Key]
        public int IDChiTietCombo { get; set; }

        public int IDCombo { get; set; }

        public int IDSanPham { get; set; }

        public virtual Combo Combo { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
