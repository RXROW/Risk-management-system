using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiApp.Migrations
{
    /// <inheritdoc />
    public partial class AddOwningGroupAndRiskFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RiskOwningGroupId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "OwningGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwningGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Risks_RiskOwningGroupId",
                table: "Risks",
                column: "RiskOwningGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Risks_OwningGroups_RiskOwningGroupId",
                table: "Risks",
                column: "RiskOwningGroupId",
                principalTable: "OwningGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Risks_OwningGroups_RiskOwningGroupId",
                table: "Risks");

            migrationBuilder.DropTable(
                name: "OwningGroups");

            migrationBuilder.DropIndex(
                name: "IX_Risks_RiskOwningGroupId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskOwningGroupId",
                table: "Risks");
        }
    }
}
