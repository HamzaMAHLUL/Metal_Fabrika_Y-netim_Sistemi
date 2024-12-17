﻿// <auto-generated />
using Metal_Fabrika_Yönetim_Sistemi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Metal_Fabrika_Yönetim_Sistemi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241217172513_FixCascadeDeleteBehavior2")]
    partial class FixCascadeDeleteBehavior2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Bolumler", b =>
                {
                    b.Property<int>("Bolum_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Bolum_ID"));

                    b.Property<string>("Bolum_ADI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bolum_ID");

                    b.ToTable("Bolumler");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Eleman_iletisim_bilgileri", b =>
                {
                    b.Property<int>("Eleman_iletisim_bilgileri_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Eleman_iletisim_bilgileri_Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ek_Telefon_No")
                        .HasColumnType("int");

                    b.Property<int>("Telefon_No")
                        .HasColumnType("int");

                    b.Property<int>("elemanlarEleman_Id")
                        .HasColumnType("int");

                    b.HasKey("Eleman_iletisim_bilgileri_Id");

                    b.HasIndex("elemanlarEleman_Id")
                        .IsUnique();

                    b.ToTable("Eleman_iletisim_bilgileri");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Eleman_kisisel_bilgileri", b =>
                {
                    b.Property<int>("Eleman_kisisel_bilgileri_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Eleman_kisisel_bilgileri_Id"));

                    b.Property<string>("cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("elemanlarEleman_Id")
                        .HasColumnType("int");

                    b.Property<string>("medeni_durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("performans")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yas")
                        .HasColumnType("int");

                    b.HasKey("Eleman_kisisel_bilgileri_Id");

                    b.HasIndex("elemanlarEleman_Id")
                        .IsUnique();

                    b.ToTable("Eleman_kisisel_bilgileri");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Elemanlar", b =>
                {
                    b.Property<int>("Eleman_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Eleman_Id"));

                    b.Property<string>("ElemanAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElemanSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bolumlerBolum_ID")
                        .HasColumnType("int");

                    b.Property<int>("personelPersonel_Id")
                        .HasColumnType("int");

                    b.Property<string>("tecrubesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Eleman_Id");

                    b.HasIndex("bolumlerBolum_ID");

                    b.HasIndex("personelPersonel_Id");

                    b.ToTable("Elemanlar");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Personel_iletisim_bilgileri", b =>
                {
                    b.Property<int>("Personel_iletisim_bilgileri_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Personel_iletisim_bilgileri_Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ek_Telefon_No")
                        .HasColumnType("int");

                    b.Property<int>("Telefon_No")
                        .HasColumnType("int");

                    b.Property<int>("personelPersonel_Id")
                        .HasColumnType("int");

                    b.HasKey("Personel_iletisim_bilgileri_Id");

                    b.HasIndex("personelPersonel_Id")
                        .IsUnique();

                    b.ToTable("Personel_iletisim_bilgileri");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Personel_kisisel_bilgileri", b =>
                {
                    b.Property<int>("Personel_Kisisel_Bilgileri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Personel_Kisisel_Bilgileri"));

                    b.Property<string>("cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medeni_durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ogretim_durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("performans")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personelPersonel_Id")
                        .HasColumnType("int");

                    b.Property<int>("yas")
                        .HasColumnType("int");

                    b.HasKey("Personel_Kisisel_Bilgileri");

                    b.HasIndex("personelPersonel_Id")
                        .IsUnique();

                    b.ToTable("Personel_kisisel_bilgileri");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Personeller", b =>
                {
                    b.Property<int>("Personel_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Personel_Id"));

                    b.Property<string>("PersonelAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bolumlerBolum_Id")
                        .HasColumnType("int");

                    b.HasKey("Personel_Id");

                    b.HasIndex("bolumlerBolum_Id")
                        .IsUnique();

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Eleman_iletisim_bilgileri", b =>
                {
                    b.HasOne("Metal_Fabrika_Yönetim_Sistemi.Models.Elemanlar", "elemanlar")
                        .WithOne("eleman_iletisim_bilgileri")
                        .HasForeignKey("Metal_Fabrika_Yönetim_Sistemi.Models.Eleman_iletisim_bilgileri", "elemanlarEleman_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("elemanlar");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Eleman_kisisel_bilgileri", b =>
                {
                    b.HasOne("Metal_Fabrika_Yönetim_Sistemi.Models.Elemanlar", "elemanlar")
                        .WithOne("eleman_Kisisel_bilgileri")
                        .HasForeignKey("Metal_Fabrika_Yönetim_Sistemi.Models.Eleman_kisisel_bilgileri", "elemanlarEleman_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("elemanlar");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Elemanlar", b =>
                {
                    b.HasOne("Metal_Fabrika_Yönetim_Sistemi.Models.Bolumler", "bolumler")
                        .WithMany("elemanlar")
                        .HasForeignKey("bolumlerBolum_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Metal_Fabrika_Yönetim_Sistemi.Models.Personeller", "personeller")
                        .WithMany("elemanlar")
                        .HasForeignKey("personelPersonel_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("bolumler");

                    b.Navigation("personeller");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Personel_iletisim_bilgileri", b =>
                {
                    b.HasOne("Metal_Fabrika_Yönetim_Sistemi.Models.Personeller", "personeller")
                        .WithOne("personel_İletisim_Bilgileri")
                        .HasForeignKey("Metal_Fabrika_Yönetim_Sistemi.Models.Personel_iletisim_bilgileri", "personelPersonel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("personeller");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Personel_kisisel_bilgileri", b =>
                {
                    b.HasOne("Metal_Fabrika_Yönetim_Sistemi.Models.Personeller", "personeller")
                        .WithOne("personel_Kisisel_Bilgileri")
                        .HasForeignKey("Metal_Fabrika_Yönetim_Sistemi.Models.Personel_kisisel_bilgileri", "personelPersonel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("personeller");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Personeller", b =>
                {
                    b.HasOne("Metal_Fabrika_Yönetim_Sistemi.Models.Bolumler", "bolumler")
                        .WithOne("personeller")
                        .HasForeignKey("Metal_Fabrika_Yönetim_Sistemi.Models.Personeller", "bolumlerBolum_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bolumler");
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Bolumler", b =>
                {
                    b.Navigation("elemanlar");

                    b.Navigation("personeller")
                        .IsRequired();
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Elemanlar", b =>
                {
                    b.Navigation("eleman_Kisisel_bilgileri")
                        .IsRequired();

                    b.Navigation("eleman_iletisim_bilgileri")
                        .IsRequired();
                });

            modelBuilder.Entity("Metal_Fabrika_Yönetim_Sistemi.Models.Personeller", b =>
                {
                    b.Navigation("elemanlar");

                    b.Navigation("personel_Kisisel_Bilgileri")
                        .IsRequired();

                    b.Navigation("personel_İletisim_Bilgileri")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
