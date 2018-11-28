namespace EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Combo")]
    public partial class Combo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Combo()
        {
            ChiTietComboes = new HashSet<ChiTietCombo>();
            CTDHs = new HashSet<CTDH>();
        }

        [Key]
        public int IDCombo { get; set; }

        [StringLength(50)]
        public string TenCombo { get; set; }

        public int? Soluong { get; set; }

        public double? GiaThayDoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietCombo> ChiTietComboes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDH> CTDHs { get; set; }
    }
}
