using Microsoft.EntityFrameworkCore.Migrations;

namespace Ahram_Clinic.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doc_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doc_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doc_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doc_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doc_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doc_Phone = table.Column<int>(type: "int", nullable: false),
                    Doc_Certificates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nur",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nur_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nur_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nur_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nur_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nur_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nur_Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nur", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Phone = table.Column<int>(type: "int", nullable: false),
                    Patient_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pat", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doc");

            migrationBuilder.DropTable(
                name: "Nur");

            migrationBuilder.DropTable(
                name: "Pat");
        }
    }
}
