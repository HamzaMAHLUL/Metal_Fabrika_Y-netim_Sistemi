using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metal_Fabrika_Yönetim_Sistemi.Migrations
{
    /// <inheritdoc />
    public partial class olustur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    Bolum_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bolum_ADI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.Bolum_ID);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Personel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bolumlerBolum_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Personel_Id);
                    table.ForeignKey(
                        name: "FK_Personeller_Bolumler_bolumlerBolum_Id",
                        column: x => x.bolumlerBolum_Id,
                        principalTable: "Bolumler",
                        principalColumn: "Bolum_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elemanlar",
                columns: table => new
                {
                    Eleman_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElemanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElemanSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tecrubesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bolumlerBolum_ID = table.Column<int>(type: "int", nullable: false),
                    personelPersonel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elemanlar", x => x.Eleman_Id);
                    table.ForeignKey(
                        name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                        column: x => x.bolumlerBolum_ID,
                        principalTable: "Bolumler",
                        principalColumn: "Bolum_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Elemanlar_Personeller_personelPersonel_Id",
                        column: x => x.personelPersonel_Id,
                        principalTable: "Personeller",
                        principalColumn: "Personel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personel_iletisim_bilgileri",
                columns: table => new
                {
                    Personel_iletisim_bilgileri_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefon_No = table.Column<int>(type: "int", nullable: false),
                    Ek_Telefon_No = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personelPersonel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel_iletisim_bilgileri", x => x.Personel_iletisim_bilgileri_Id);
                    table.ForeignKey(
                        name: "FK_Personel_iletisim_bilgileri_Personeller_personelPersonel_Id",
                        column: x => x.personelPersonel_Id,
                        principalTable: "Personeller",
                        principalColumn: "Personel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personel_kisisel_bilgileri",
                columns: table => new
                {
                    Personel_Kisisel_Bilgileri = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yas = table.Column<int>(type: "int", nullable: false),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ogretim_durumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medeni_durumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    performans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personelPersonel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel_kisisel_bilgileri", x => x.Personel_Kisisel_Bilgileri);
                    table.ForeignKey(
                        name: "FK_Personel_kisisel_bilgileri_Personeller_personelPersonel_Id",
                        column: x => x.personelPersonel_Id,
                        principalTable: "Personeller",
                        principalColumn: "Personel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eleman_iletisim_bilgileri",
                columns: table => new
                {
                    Eleman_iletisim_bilgileri_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefon_No = table.Column<int>(type: "int", nullable: false),
                    Ek_Telefon_No = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    elemanlarEleman_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleman_iletisim_bilgileri", x => x.Eleman_iletisim_bilgileri_Id);
                    table.ForeignKey(
                        name: "FK_Eleman_iletisim_bilgileri_Elemanlar_elemanlarEleman_Id",
                        column: x => x.elemanlarEleman_Id,
                        principalTable: "Elemanlar",
                        principalColumn: "Eleman_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eleman_kisisel_bilgileri",
                columns: table => new
                {
                    Eleman_kisisel_bilgileri_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yas = table.Column<int>(type: "int", nullable: false),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medeni_durumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    performans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    elemanlarEleman_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleman_kisisel_bilgileri", x => x.Eleman_kisisel_bilgileri_Id);
                    table.ForeignKey(
                        name: "FK_Eleman_kisisel_bilgileri_Elemanlar_elemanlarEleman_Id",
                        column: x => x.elemanlarEleman_Id,
                        principalTable: "Elemanlar",
                        principalColumn: "Eleman_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eleman_iletisim_bilgileri_elemanlarEleman_Id",
                table: "Eleman_iletisim_bilgileri",
                column: "elemanlarEleman_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Eleman_kisisel_bilgileri_elemanlarEleman_Id",
                table: "Eleman_kisisel_bilgileri",
                column: "elemanlarEleman_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elemanlar_bolumlerBolum_ID",
                table: "Elemanlar",
                column: "bolumlerBolum_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Elemanlar_personelPersonel_Id",
                table: "Elemanlar",
                column: "personelPersonel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_iletisim_bilgileri_personelPersonel_Id",
                table: "Personel_iletisim_bilgileri",
                column: "personelPersonel_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personel_kisisel_bilgileri_personelPersonel_Id",
                table: "Personel_kisisel_bilgileri",
                column: "personelPersonel_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_bolumlerBolum_Id",
                table: "Personeller",
                column: "bolumlerBolum_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eleman_iletisim_bilgileri");

            migrationBuilder.DropTable(
                name: "Eleman_kisisel_bilgileri");

            migrationBuilder.DropTable(
                name: "Personel_iletisim_bilgileri");

            migrationBuilder.DropTable(
                name: "Personel_kisisel_bilgileri");

            migrationBuilder.DropTable(
                name: "Elemanlar");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Bolumler");
        }
    }
}
