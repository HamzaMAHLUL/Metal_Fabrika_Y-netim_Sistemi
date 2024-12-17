using Metal_Fabrika_Yönetim_Sistemi.Models;
using Microsoft.EntityFrameworkCore;

namespace Metal_Fabrika_Yönetim_Sistemi.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor to configure the DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet Definitions
        public DbSet<Bolumler> Bolumler { get; set; }
        public DbSet<Personeller> Personeller { get; set; }
        public DbSet<Personel_iletisim_bilgileri> Personel_iletisim_bilgileri { get; set; }
        public DbSet<Personel_kisisel_bilgileri> Personel_kisisel_bilgileri { get; set; }
        public DbSet<Elemanlar> Elemanlar { get; set; }
        public DbSet<Eleman_iletisim_bilgileri> Eleman_iletisim_bilgileri { get; set; }
        public DbSet<Eleman_kisisel_bilgileri> Eleman_kisisel_bilgileri { get; set; }

        // Configuring relationships and specifying delete behavior
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Elemanlar and Personeller
            modelBuilder.Entity<Elemanlar>()
                .HasOne(e => e.personeller)
                .WithMany(p => p.elemanlar)
                .HasForeignKey(e => e.personelPersonel_Id)
                .OnDelete(DeleteBehavior.NoAction); // Change to NoAction or SetNull for Personeller

            // Configure the relationship between Elemanlar and Bolumler
            modelBuilder.Entity<Elemanlar>()
                .HasOne(e => e.bolumler)
                .WithMany(b => b.elemanlar)
                .HasForeignKey(e => e.bolumlerBolum_ID)
                .OnDelete(DeleteBehavior.Cascade); // Keep CASCADE for Bolumler
        }
    }
}
