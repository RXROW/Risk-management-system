using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRiskTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControlEffectivenessId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "InherentRiskRatingId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "ResidualRiskRatingId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskDriverId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskSourceId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskSubCategoryId",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskTypeId",
                table: "Risks");

            migrationBuilder.AlterColumn<Guid>(
                name: "RiskStatementId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RiskOwnerId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Risks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncWithEntityOwner",
                table: "Risks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RiskDescription",
                table: "Risks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Risks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "IsSyncWithEntityOwner",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "RiskDescription",
                table: "Risks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Risks");

            migrationBuilder.AlterColumn<Guid>(
                name: "RiskStatementId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RiskOwnerId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ControlEffectivenessId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InherentRiskRatingId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ResidualRiskRatingId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RiskDriverId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RiskSourceId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RiskSubCategoryId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RiskTypeId",
                table: "Risks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
