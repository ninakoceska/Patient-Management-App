using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentistApplication.Migrations
{
    /// <inheritdoc />
    public partial class Renaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MBR",
                table: "Patients",
                newName: "EMBG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EMBG",
                table: "Patients",
                newName: "MBR");
        }
    }
}
