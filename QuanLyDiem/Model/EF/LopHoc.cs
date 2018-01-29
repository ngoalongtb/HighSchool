namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            LopHocHocSinhs = new HashSet<LopHocHocSinh>();
        }

        [Key]
        [StringLength(10)]
        [DisplayName("Mã")]
        public string ma { get; set; }

        [StringLength(10)]
        [DisplayName("Mã môn học")]
        public string ma_mon_hoc { get; set; }

        [StringLength(10)]
        [DisplayName("Mã kỳ học")]
        public string ma_ky_hoc { get; set; }

        [DisplayName("Đã xóa")]
        public bool? da_xoa { get; set; }

        [StringLength(10)]
        [DisplayName("Mã giáo viên")]
        public string ma_giao_vien { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual KyHoc KyHoc { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocHocSinh> LopHocHocSinhs { get; set; }
    }
}
