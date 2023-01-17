using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomValidation_Example.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    lastname = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(max)", nullable: false),
                    phone = table.Column<string>(type: "varchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    DOA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    password = table.Column<string>(type: "varchar(max)", nullable: false),
                    confirmpassword = table.Column<string>(type: "varchar(max)", nullable: false),
                    url = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
