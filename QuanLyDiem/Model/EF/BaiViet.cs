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
        [StringLength(10)]
        public string ma { get; set; }

        public string noi_dung { get; set; }

        public int? do_uu_tien { get; set; }

        public bool? da_xoa { get; set; }

        [StringLength(10)]
        public string tai_khoan { get; set; }

        [StringLength(255)]
        public string hinh_anh { get; set; }

        [StringLength(10)]
        public string ma_danh_muc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
