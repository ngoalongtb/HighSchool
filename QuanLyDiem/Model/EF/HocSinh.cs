namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Mã")]
        public string ma { get; set; }

        [StringLength(255)]
        [DisplayName("Tên")]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày sinh")]
        public DateTime? ngay_sinh { get; set; }

        [DisplayName("Đã xóa")]
        public bool? da_xoa { get; set; }

        [StringLength(10)]
        [DisplayName("Mã lớp ổn định")]
        public string ma_lop_on_dinh { get; set; }

        [StringLength(20)]
        [DisplayName("Số điện thoại")]
        public string so_dien_thoai { get; set; }

        [StringLength(255)]
        [DisplayName("Email")]
        public string email { get; set; }

        [StringLength(255)]
        [DisplayName("Hình ảnh")]
        public string url_anh { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày nhập học")]
        public DateTime? ngay_nhap_hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocHocSinh> LopHocHocSinhs { get; set; }
    }
}
