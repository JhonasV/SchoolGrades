using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolGrades.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cod = table.Column<string>(type: "TEXT", nullable: true),
                    SubjectName = table.Column<string>(type: "TEXT", nullable: true),
                    CareerName = table.Column<string>(type: "TEXT", nullable: true),
                    Quater = table.Column<string>(type: "TEXT", nullable: true),
                    StudentName = table.Column<string>(type: "TEXT", nullable: true),
                    StudentId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolGrades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolGrades");
        }
    }
}
