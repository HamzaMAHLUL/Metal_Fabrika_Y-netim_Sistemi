using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metal_Fabrika_Yönetim_Sistemi.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadeDeleteBehavior2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar");

            migrationBuilder.AddForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar",
                column: "bolumlerBolum_ID",
                principalTable: "Bolumler",
                principalColumn: "Bolum_ID"
               );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar");

            migrationBuilder.AddForeignKey(
                name: "FK_Elemanlar_Bolumler_bolumlerBolum_ID",
                table: "Elemanlar",
                column: "bolumlerBolum_ID",
                principalTable: "Bolumler",
                principalColumn: "Bolum_ID"
               );
        }
    }
}
