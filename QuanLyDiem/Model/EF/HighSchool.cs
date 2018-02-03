namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HighSchool : DbContext
    {
        public HighSchool()
            : base("name=HighSchool")
        {
        }

        public virtual DbSet<BaiViet> BaiViets { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<KyHoc> KyHocs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<LopHocHocSinh> LopHocHocSinhs { get; set; }
        public virtual DbSet<LopOnDinh> LopOnDinhs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiViet>()
                .Property(e => e.tai_khoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaiViet>()
                .Property(e => e.hinh_anh)
                .IsUnicode(false);

            modelBuilder.Entity<BaiViet>()
                .Property(e => e.ma_danh_muc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.BaiViets)
                .WithOptional(e => e.DanhMuc)
                .HasForeignKey(e => e.ma_danh_muc);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.url_anh)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.so_dien_thoai)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.LopHocs)
                .WithOptional(e => e.GiaoVien)
                .HasForeignKey(e => e.ma_giao_vien);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.LopOnDinhs)
                .WithOptional(e => e.GiaoVien)
                .HasForeignKey(e => e.ma_gv_chu_nhiem);

            modelBuilder.Entity<GiaoVien>()
                .HasOptional(e => e.TaiKhoan)
                .WithRequired(e => e.GiaoVien);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.ma_lop_on_dinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.so_dien_thoai)
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.url_anh)
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .HasMany(e => e.LopHocHocSinhs)
                .WithRequired(e => e.HocSinh)
                .HasForeignKey(e => e.ma_hoc_sinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KyHoc>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KyHoc>()
                .HasMany(e => e.LopHocs)
                .WithOptional(e => e.KyHoc)
                .HasForeignKey(e => e.ma_ky_hoc);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ma_mon_hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ma_ky_hoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ma_giao_vien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.ma_lop_on_dinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.LopHocHocSinhs)
                .WithRequired(e => e.LopHoc)
                .HasForeignKey(e => e.ma_lop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LopHocHocSinh>()
                .Property(e => e.ma_lop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopHocHocSinh>()
                .Property(e => e.ma_hoc_sinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopOnDinh>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopOnDinh>()
                .Property(e => e.ma_khoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopOnDinh>()
                .Property(e => e.ma_gv_chu_nhiem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LopOnDinh>()
                .HasMany(e => e.HocSinhs)
                .WithOptional(e => e.LopOnDinh)
                .HasForeignKey(e => e.ma_lop_on_dinh);

            modelBuilder.Entity<LopOnDinh>()
                .HasMany(e => e.LopHocs)
                .WithOptional(e => e.LopOnDinh)
                .HasForeignKey(e => e.ma_lop_on_dinh);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.ma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.LopHocs)
                .WithOptional(e => e.MonHoc)
                .HasForeignKey(e => e.ma_mon_hoc);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.tai_khoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.mat_khau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.url_anh)
                .IsUnicode(false);
        }
    }
}
