using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metal_Fabrika_Yönetim_Sistemi.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadeDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Elemanlar_Personeller_personelPersonel_Id",
                table: "Elemanlar");

            migrationBuilder.AddForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar",
                column: "bolumlerBolum_ID",
                principalTable: "Bolumler",
                principalColumn: "Bolum_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Elemanlar_Personeller_personelPersonel_Id",
                table: "Elemanlar",
                column: "personelPersonel_Id",
                principalTable: "Personeller",
                principalColumn: "Personel_Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Elemanlar_Personeller_personelPersonel_Id",
                table: "Elemanlar");

            migrationBuilder.AddForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar",
                column: "bolumlerBolum_ID",
                principalTable: "Bolumler",
                principalColumn: "Bolum_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Elemanlar_Personeller_personelPersonel_Id",
                table: "Elemanlar",
                column: "personelPersonel_Id",
                principalTable: "Personeller",
                principalColumn: "Personel_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
