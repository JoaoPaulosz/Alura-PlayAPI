using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alura_Play.Migrations
{
    /// <inheritdoc />
    public partial class Alterandonomedastabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Plays",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Plays",
                newName: "Descricao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Plays",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Plays",
                newName: "Description");
        }
    }
}
