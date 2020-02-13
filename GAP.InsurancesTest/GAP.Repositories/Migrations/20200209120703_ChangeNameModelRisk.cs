using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Repositories.Migrations
{
    public partial class ChangeNameModelRisk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_RyskType_RyskTypeId",
                table: "Insurance");

            migrationBuilder.DropIndex(
                name: "IX_Insurance_RyskTypeId",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "RyskTypeId",
                table: "Insurance");

            migrationBuilder.AddColumn<int>(
                name: "RiskTypeId",
                table: "Insurance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_RiskTypeId",
                table: "Insurance",
                column: "RiskTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_RyskType_RiskTypeId",
                table: "Insurance",
                column: "RiskTypeId",
                principalTable: "RyskType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_RyskType_RiskTypeId",
                table: "Insurance");

            migrationBuilder.DropIndex(
                name: "IX_Insurance_RiskTypeId",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "RiskTypeId",
                table: "Insurance");

            migrationBuilder.AddColumn<int>(
                name: "RyskTypeId",
                table: "Insurance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_RyskTypeId",
                table: "Insurance",
                column: "RyskTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_RyskType_RyskTypeId",
                table: "Insurance",
                column: "RyskTypeId",
                principalTable: "RyskType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
