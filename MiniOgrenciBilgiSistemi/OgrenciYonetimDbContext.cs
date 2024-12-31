using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOgrenciBilgiSistemi
{
    internal class OgrenciYonetimDbContext: DbContext
    {
        public DbSet<models.Ogrenci> Ogrenciler { get; set; }
        public DbSet<models.Ders> Dersler { get; set; }
        public DbSet<models.Sinif> Siniflar { get; set; }
        public DbSet<models.OgrenciDers> OgrenciDersler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source = .; Initial Catalog = OgrenciBilgiSistemi; Integrated Security = true; TrustServerCertificate = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //?

            #region OgrenciModel
            modelBuilder.Entity<models.Ogrenci>()
                .Property(ogr => ogr.Ad)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(30);

            modelBuilder.Entity<models.Ogrenci>()
                .Property(ogr => ogr.Soyad)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(30);


            modelBuilder.Entity<models.Ogrenci>()
                .HasIndex(ogr => ogr.Numara)
                .IsUnique();
            modelBuilder.Entity<models.Ogrenci>()
                .Property(ogr => ogr.Numara)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);


            modelBuilder.Entity<models.Ogrenci>()
                .HasOne(o => o.Sinif)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifId);

            #endregion

            #region SinifModel

            modelBuilder.Entity<models.Sinif>()
                .Property(s => s.SinifAd)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(30);

            modelBuilder.Entity<models.Sinif>()
                .Property(s => s.Kontenjan)
                .IsRequired()
                .HasDefaultValue(0);

            #endregion

            #region OgrenciDersModel

            modelBuilder.Entity<models.OgrenciDers>()
                .HasKey(od => new { od.OgrenciId, od.DersId });

            modelBuilder.Entity<models.OgrenciDers>()
                .HasOne(o => o.Ogrenci)
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(o => o.OgrenciId);

            modelBuilder.Entity<models.OgrenciDers>()
                .HasOne(d => d.Ders)
                .WithMany(d => d.OgrenciDersler)
                .HasForeignKey(d => d.DersId);


            #endregion

        }
    }
}