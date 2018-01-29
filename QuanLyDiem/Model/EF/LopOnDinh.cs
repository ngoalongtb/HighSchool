namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopOnDinh")]
    public partial class LopOnDinh
    {
        [Key]
        [StringLength(10)]
        [DisplayName("Mã")]
        public string ma { get; set; }

        [StringLength(255)]
        [DisplayName("Tên")]
        public string ten { get; set; }

        [StringLength(10)]
        [DisplayName("Mã khoa")]
        public string ma_khoa { get; set; }

        [DisplayName("Đã xóa")]
        public bool? da_xoa { get; set; }

        [StringLength(10)]
        [DisplayName("Mã giao viên chủ nhiệm")]
        public string ma_gv_chu_nhiem { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
