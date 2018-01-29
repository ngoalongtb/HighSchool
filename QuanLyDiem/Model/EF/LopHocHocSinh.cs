namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHocHocSinh")]
    public partial class LopHocHocSinh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        [DisplayName("Mã lớp")]
        public string ma_lop { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        [DisplayName("Mã học sinh")]
        public string ma_hoc_sinh { get; set; }

        [DisplayName("Điểm trên lớp")]
        public double? diemTrenLop { get; set; }

        [DisplayName("Điểm thi")]
        public double? diemThi { get; set; }

        [DisplayName("Đã xóa")]
        public bool? da_xoa { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
