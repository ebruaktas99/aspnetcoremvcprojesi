using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoremMvcDepartman.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departID",
                table: "Personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departID",
                table: "Personels",
                column: "departID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmans_departID",
                table: "Personels",
                column: "departID",
                principalTable: "Departmans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmans_departID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_departID",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "departID",
                table: "Personels");
        }
    }
}
