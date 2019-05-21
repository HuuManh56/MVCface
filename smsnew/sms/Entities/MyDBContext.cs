namespace sms.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDBContext : DbContext
    {
        public MyDBContext()
            : base("name=MyDBContext")
        {
        }
        public virtual DbSet<DiemDanh> DiemDanhs { get; set; }
        public virtual DbSet<HocKy> HocKies { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<HocPhan_HocKy> HocPhan_HocKy { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }
        public virtual DbSet<NamHoc> NamHocs { get; set; }
        public virtual DbSet<NienKhoa> NienKhoas { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<SV_LHP> SV_LHP { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NamHoc>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<NamHoc>()
                .HasMany(e => e.HocKies)
                .WithOptional(e => e.NamHoc)
                .HasForeignKey(e => e.Id_Namhoc);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.image)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.DiemDanhs)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SV_LHP>()
                .Property(e => e.Diem1)
                .HasPrecision(4, 2);

            modelBuilder.Entity<SV_LHP>()
                .Property(e => e.Diem2)
                .HasPrecision(4, 2);

            modelBuilder.Entity<SV_LHP>()
                .Property(e => e.Diem3)
                .HasPrecision(4, 2);
        }
    }
}
