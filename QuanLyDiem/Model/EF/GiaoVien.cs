namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien()
        {
            LopHocs = new HashSet<LopHoc>();
            LopOnDinhs = new HashSet<LopOnDinh>();
        }

        [Key]
        [StringLength(10)]
        public string ma { get; set; }

        public bool? da_xoa { get; set; }

        [StringLength(255)]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(255)]
        public string url_anh { get; set; }

        [StringLength(20)]
        public string so_dien_thoai { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_vao_truong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopOnDinh> LopOnDinhs { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
