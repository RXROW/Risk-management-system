using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRiskStatementAndRiskFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RiskStatementId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "RiskStatements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Statement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskStatements", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Risks_RiskStatementId",
                table: "Risks",
                column: "RiskStatementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Risks_RiskStatements_RiskStatementId",
                table: "Risks",
                column: "RiskStatementId",
                principalTable: "RiskStatements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Risks_RiskStatements_RiskStatementId",
                table: "Risks");

            migrationBuilder.DropTable(
                name: "RiskStatements");

            migrationBuilder.DropIndex(
                name: "IX_Risks_RiskStatementId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskStatementId",
                table: "Risks");
        }
    }
}
