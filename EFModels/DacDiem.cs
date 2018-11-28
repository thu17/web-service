namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DacDiem")]
    public partial class DacDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DacDiem()
        {
            SanPham_DacDiem = new HashSet<SanPham_DacDiem>();
        }

        [Key]
        public int IDDacDiem { get; set; }

        [Column("_DacDiem")]
        [StringLength(20)]
        public string C_DacDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham_DacDiem> SanPham_DacDiem { get; set; }
    }
}
