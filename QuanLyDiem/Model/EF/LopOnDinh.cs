namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopOnDinh")]
    public partial class LopOnDinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopOnDinh()
        {
            LopHocs = new HashSet<LopHoc>();
        }

        [Key]
        [StringLength(10)]
        public string ma { get; set; }

        [StringLength(255)]
        public string ten { get; set; }

        [StringLength(10)]
        public string ma_khoa { get; set; }

        [StringLength(10)]
        public string ma_gv_chu_nhiem { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
