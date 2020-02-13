using Microsoft.EntityFrameworkCore.Migrations;

namespace GAP.Repositories.Migrations
{
    public partial class AddClientIdToInsuranceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Client_ClientId",
                table: "Insurance");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Insurance",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_Client_ClientId",
                table: "Insurance",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Client_ClientId",
                table: "Insurance");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Insurance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_Client_ClientId",
                table: "Insurance",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
