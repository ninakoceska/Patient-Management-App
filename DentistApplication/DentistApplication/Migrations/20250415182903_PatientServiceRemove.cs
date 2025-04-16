using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentistApplication.Migrations
{
    /// <inheritdoc />
    public partial class PatientServiceRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientServices_Services_ServiceId",
                table: "PatientServices");

            migrationBuilder.DropIndex(
                name: "IX_PatientServices_ServiceId",
                table: "PatientServices");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "PatientServices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "PatientServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientServices_ServiceId",
                table: "PatientServices",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientServices_Services_ServiceId",
                table: "PatientServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id");
        }
    }
}
