namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KyHoc")]
    public partial class KyHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KyHoc()
        {
            LopHocs = new HashSet<LopHoc>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã")]
        public string ma { get; set; }

        [StringLength(10)]
        [Display(Name = "Kỳ học")]
        public string ky_hoc { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Bắt đầu")]
        public DateTime? bat_dau { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Kết thúc")]
        public DateTime? ket_thuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
