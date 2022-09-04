using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task3.Migrations
{
    public partial class changeids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "Employees",
                newName: "CompanyID");

            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "Companies",
                newName: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyID",
                table: "Employees",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_CompanyID",
                table: "Employees",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_CompanyID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CompanyID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Employees",
                newName: "companyId");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Companies",
                newName: "companyId");
        }
    }
}
