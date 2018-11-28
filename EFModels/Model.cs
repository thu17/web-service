namespace EFModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=DBConnection")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<ChiTietCombo> ChiTietComboes { get; set; }
        public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }
        public virtual DbSet<Combo> Comboes { get; set; }
        public virtual DbSet<CTDH> CTDHs { get; set; }
        public virtual DbSet<CTSPDatHang> CTSPDatHangs { get; set; }
        public virtual DbSet<DacDiem> DacDiems { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<KichCo> KichCoes { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<nhomhang> nhomhangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPham_DacDiem> SanPham_DacDiem { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieux { get; set; }
        public virtual DbSet<TonKho> TonKhoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSanPham>()
                .HasMany(e => e.CTSPDatHangs)
                .WithRequired(e => e.ChiTietSanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Combo>()
                .HasMany(e => e.ChiTietComboes)
                .WithRequired(e => e.Combo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Combo>()
                .HasMany(e => e.CTDHs)
                .WithRequired(e => e.Combo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTDH>()
                .HasMany(e => e.CTSPDatHangs)
                .WithRequired(e => e.CTDH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DacDiem>()
                .HasMany(e => e.SanPham_DacDiem)
                .WithRequired(e => e.DacDiem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.CTDHs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<khachhang>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.khachhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KichCo>()
                .HasMany(e => e.ChiTietSanPhams)
                .WithRequired(e => e.KichCo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MauSac>()
                .HasMany(e => e.ChiTietSanPhams)
                .WithRequired(e => e.MauSac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nhomhang>()
                .HasMany(e => e.KichCoes)
                .WithRequired(e => e.nhomhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nhomhang>()
                .HasMany(e => e.ThuongHieux)
                .WithRequired(e => e.nhomhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietComboes)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietSanPhams)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.SanPham_DacDiem)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.TonKhoes)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThuongHieu>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.ThuongHieu)
                .WillCascadeOnDelete(false);
        }
    }
}
