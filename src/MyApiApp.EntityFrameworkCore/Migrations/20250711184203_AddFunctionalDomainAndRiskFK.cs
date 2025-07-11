using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFunctionalDomainAndRiskFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FunctionalDomainId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "FunctionalDomains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionalDomains", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Risks_FunctionalDomainId",
                table: "Risks",
                column: "FunctionalDomainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Risks_FunctionalDomains_FunctionalDomainId",
                table: "Risks",
                column: "FunctionalDomainId",
                principalTable: "FunctionalDomains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Risks_FunctionalDomains_FunctionalDomainId",
                table: "Risks");

            migrationBuilder.DropTable(
                name: "FunctionalDomains");

            migrationBuilder.DropIndex(
                name: "IX_Risks_FunctionalDomainId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "FunctionalDomainId",
                table: "Risks");
        }
    }
}
