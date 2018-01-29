namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Mã")]
        public string ma { get; set; }

        [DisplayName("Đã xóa")]
        public bool? da_xoa { get; set; }

        [StringLength(255)]
        [DisplayName("Tên")]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày sinh")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(255)]
        [DisplayName("Hình ảnh")]
        public string url_anh { get; set; }

        [StringLength(20)]
        [DisplayName("Số điện thoại")]
        public string so_dien_thoai { get; set; }

        [StringLength(255)]
        [DisplayName("Email")]
        public string email { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày vào trường")]
        public DateTime? ngay_vao_truong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopOnDinh> LopOnDinhs { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
