namespace Model.EF
{
    using System;
    using System.Collections.Generic;
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
        [Display(Name = "Mã")]
        public string ma { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã môn học")]
        public string ma_mon_hoc { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã kỳ học")]
        public string ma_ky_hoc { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã giáo viên")]
        public string ma_giao_vien { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã lớp ổn định")]
        public string ma_lop_on_dinh { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual KyHoc KyHoc { get; set; }

        public virtual LopOnDinh LopOnDinh { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocHocSinh> LopHocHocSinhs { get; set; }
    }
}
