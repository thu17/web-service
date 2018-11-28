namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SanPham_DacDiem
    {
        [Key]
        public int IDSanPham_DacDiem { get; set; }

        public int IDSanPham { get; set; }

        public int IDDacDiem { get; set; }

        public virtual DacDiem DacDiem { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
