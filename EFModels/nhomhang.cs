namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhomhang")]
    public partial class nhomhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhomhang()
        {
            KichCoes = new HashSet<KichCo>();
            ThuongHieux = new HashSet<ThuongHieu>();
        }

        [Key]
        public int IDNhomhang { get; set; }

        [StringLength(100)]
        public string Tennhomhang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KichCo> KichCoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuongHieu> ThuongHieux { get; set; }
    }
}
