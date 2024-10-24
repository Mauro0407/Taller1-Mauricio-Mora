using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller1_Mauricio_Mora.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Equipo",
                table: "Jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador",
                column: "IdEquipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador",
                column: "IdEquipo",
                principalTable: "Equipo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador");

            migrationBuilder.DropIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador");

            migrationBuilder.AddColumn<string>(
                name: "Equipo",
                table: "Jugador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
