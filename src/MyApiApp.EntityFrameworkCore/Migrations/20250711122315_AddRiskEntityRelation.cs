using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRiskEntityRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Risks_EntityId",
                table: "Risks",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Risks_Entities_EntityId",
                table: "Risks",
                column: "EntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Risks_Entities_EntityId",
                table: "Risks");

            migrationBuilder.DropIndex(
                name: "IX_Risks_EntityId",
                table: "Risks");
        }
    }
}
