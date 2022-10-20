using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Helpdesk.Data.Migrations
{
    public partial class Com1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comp",
                columns: table => new
                {
                    idCompany = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCompany = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    nrOfBuilding = table.Column<int>(type: "int", nullable: true),
                    nrApartments = table.Column<int>(type: "int", nullable: true),
                    domains = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: true),
                    regon = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    krs = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WebAdres = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comp", x => x.idCompany);
                });

            migrationBuilder.CreateTable(
                name: "Empl",
                columns: table => new
                {
                    idEmployes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailEmp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    workplace = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    workNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empl", x => x.idEmployes);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comp");

            migrationBuilder.DropTable(
                name: "Empl");
        }
    }
}
