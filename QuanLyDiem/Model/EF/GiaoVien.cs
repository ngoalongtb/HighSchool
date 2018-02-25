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
        [Display(Name = "Mã")]
        public string ma { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên")]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(255)]
        [Display(Name = "Hinh ảnh")]
        public string url_anh { get; set; }

        [StringLength(20)]
        [Display(Name = "Số điện thoại")]
        public string so_dien_thoai { get; set; }

        [StringLength(255)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày vào trường")]
        public DateTime? ngay_vao_truong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopOnDinh> LopOnDinhs { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
