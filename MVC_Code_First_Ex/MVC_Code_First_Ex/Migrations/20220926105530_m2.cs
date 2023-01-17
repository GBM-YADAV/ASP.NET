using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Code_First_Ex.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "depno",
                table: "Employees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "depno",
                table: "Employees");
        }
    }
}
