using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myapp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gpa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gpa2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceEndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeySkill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeySkill2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceStartDate2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceEndDate2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeySkill3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeySkill4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificate1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificate2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificate3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificate4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitHub = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CV");
        }
    }
}
