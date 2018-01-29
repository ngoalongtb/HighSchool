namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [Key]
        [StringLength(10)]
        [DisplayName("Mã")]
        public string ma { get; set; }

        [DisplayName("Nội dung")]
        public string noi_dung { get; set; }

        [DisplayName("Độ ưu tiên")]
        public int? do_uu_tien { get; set; }

        [DisplayName("Đã xóa")]
        public bool? da_xoa { get; set; }

        [StringLength(10)]
        [DisplayName("Tài khoản")]
        public string tai_khoan { get; set; }

        [StringLength(255)]
        [DisplayName("Hình ảnh")]
        public string hinh_anh { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
