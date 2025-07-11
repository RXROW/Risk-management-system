using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDomainAreaAndRiskFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DomainAreaId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DomainAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FunctionalDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DomainAreas_FunctionalDomains_FunctionalDomainId",
                        column: x => x.FunctionalDomainId,
                        principalTable: "FunctionalDomains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Risks_DomainAreaId",
                table: "Risks",
                column: "DomainAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainAreas_FunctionalDomainId",
                table: "DomainAreas",
                column: "FunctionalDomainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Risks_DomainAreas_DomainAreaId",
                table: "Risks",
                column: "DomainAreaId",
                principalTable: "DomainAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Risks_DomainAreas_DomainAreaId",
                table: "Risks");

            migrationBuilder.DropTable(
                name: "DomainAreas");

            migrationBuilder.DropIndex(
                name: "IX_Risks_DomainAreaId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "DomainAreaId",
                table: "Risks");
        }
    }
}
