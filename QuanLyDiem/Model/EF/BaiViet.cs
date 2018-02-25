namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [Key]
        [Display(Name = "Mã")]
        public int ma { get; set; }

        [Display(Name = "Nội dung")]
        public string noi_dung { get; set; }

        [Display(Name = "Độ ưu tiên")]
        public int? do_uu_tien { get; set; }


        [StringLength(10)]
        [Display(Name = "Tài khoản")]
        public string tai_khoan { get; set; }

        [StringLength(255)]
        [Display(Name = "Hình ảnh")]
        public string hinh_anh { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã danh mục")]
        public string ma_danh_muc { get; set; }

        [StringLength(255)]
        [Display(Name = "Tiêu đề")]
        public string tieu_de { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
