using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentistApplication.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    EMBG = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    EmailAddress = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    HomeAddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ServiceName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Euro = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ServiceName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PatientId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ServiceDescription = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: true),
                    PricePaid = table.Column<int>(type: "INTEGER", nullable: true),
                    Euro = table.Column<bool>(type: "INTEGER", nullable: false),
                    Done = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientServices_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientServices_PatientId",
                table: "PatientServices",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientServices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
