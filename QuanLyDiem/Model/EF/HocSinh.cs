namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocSinh()
        {
            LopHocHocSinhs = new HashSet<LopHocHocSinh>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã")]
        public string ma { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên")]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã lớp ổn định")]
        public string ma_lop_on_dinh { get; set; }

        [StringLength(20)]
        [Display(Name = "Số điện thoại")]
        public string so_dien_thoai { get; set; }

        [StringLength(255)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [StringLength(255)]
        [Display(Name = "Hình ảnh")]
        public string url_anh { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày nhập học")]
        public DateTime? ngay_nhap_hoc { get; set; }

        public virtual LopOnDinh LopOnDinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocHocSinh> LopHocHocSinhs { get; set; }
    }
}
