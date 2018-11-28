namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KichCo")]
    public partial class KichCo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KichCo()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        public int IDKichCo { get; set; }

        [Column("_KichCo")]
        [StringLength(5)]
        public string C_KichCo { get; set; }

        public int IDNhomHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }

        public virtual nhomhang nhomhang { get; set; }
    }
}
