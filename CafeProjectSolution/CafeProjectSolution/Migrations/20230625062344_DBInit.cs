using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeProjectSolution.Migrations
{
    /// <inheritdoc />
    public partial class DBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CafeData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CafeData", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CafeEmployees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CafeId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    EmployeesId = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CafeEmployees", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmployeesData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesData", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CafeData");

            migrationBuilder.DropTable(
                name: "CafeEmployees");

            migrationBuilder.DropTable(
                name: "EmployeesData");
        }
    }
}
