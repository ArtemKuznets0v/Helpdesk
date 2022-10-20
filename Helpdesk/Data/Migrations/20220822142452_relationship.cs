using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Helpdesk.Data.Migrations
{
    public partial class relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idCompany",
                table: "Notific",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idEmployes",
                table: "Notific",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idProgram",
                table: "Notific",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "programId",
                table: "Notific",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notific_idCompany",
                table: "Notific",
                column: "idCompany");

            migrationBuilder.CreateIndex(
                name: "IX_Notific_idEmployes",
                table: "Notific",
                column: "idEmployes");

            migrationBuilder.CreateIndex(
                name: "IX_Notific_idProgram",
                table: "Notific",
                column: "idProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Notific_programId",
                table: "Notific",
                column: "programId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notific_Comp_idCompany",
                table: "Notific",
                column: "idCompany",
                principalTable: "Comp",
                principalColumn: "idCompany",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notific_Empl_idEmployes",
                table: "Notific",
                column: "idEmployes",
                principalTable: "Empl",
                principalColumn: "idEmployes",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notific_Prog_idProgram",
                table: "Notific",
                column: "idProgram",
                principalTable: "Prog",
                principalColumn: "idProgram",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notific_Vers_programId",
                table: "Notific",
                column: "programId",
                principalTable: "Vers",
                principalColumn: "programId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notific_Comp_idCompany",
                table: "Notific");

            migrationBuilder.DropForeignKey(
                name: "FK_Notific_Empl_idEmployes",
                table: "Notific");

            migrationBuilder.DropForeignKey(
                name: "FK_Notific_Prog_idProgram",
                table: "Notific");

            migrationBuilder.DropForeignKey(
                name: "FK_Notific_Vers_programId",
                table: "Notific");

            migrationBuilder.DropIndex(
                name: "IX_Notific_idCompany",
                table: "Notific");

            migrationBuilder.DropIndex(
                name: "IX_Notific_idEmployes",
                table: "Notific");

            migrationBuilder.DropIndex(
                name: "IX_Notific_idProgram",
                table: "Notific");

            migrationBuilder.DropIndex(
                name: "IX_Notific_programId",
                table: "Notific");

            migrationBuilder.DropColumn(
                name: "idCompany",
                table: "Notific");

            migrationBuilder.DropColumn(
                name: "idEmployes",
                table: "Notific");

            migrationBuilder.DropColumn(
                name: "idProgram",
                table: "Notific");

            migrationBuilder.DropColumn(
                name: "programId",
                table: "Notific");
        }
    }
}
