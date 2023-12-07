using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutMania.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Teams",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Seasons",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Players",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Leagues",
                newName: "UpdatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Teams",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Seasons",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Players",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Leagues",
                newName: "DeletedAt");
        }
    }
}
