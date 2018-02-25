namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            BaiViets = new HashSet<BaiViet>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Tài khoản")]
        public string tai_khoan { get; set; }

        [StringLength(255)]
        [Display(Name = "Mật khẩu")]
        public string mat_khau { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên hiển thị")]
        public string ten_hien_thi { get; set; }

        [StringLength(255)]
        [Display(Name = "Hình ảnh")]
        public string url_anh { get; set; }

        [Display(Name = "Là admin")]
        public bool? la_admin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiViet> BaiViets { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
