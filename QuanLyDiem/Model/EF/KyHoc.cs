namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Mã")]
        public string ma { get; set; }

        [StringLength(10)]
        [DisplayName("Kỳ học")]
        public string ky_hoc { get; set; }

        [DisplayName("Đã xóa")]
        public bool? da_xoa { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Bắt đầu")]
        public DateTime? bat_dau { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Kết thúc")]
        public DateTime? ket_thuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
