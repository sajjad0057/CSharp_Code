using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Ex.Migrations
{
    public partial class AddStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)   // Up method explain , how can be table created in DB .  
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cgpa = table.Column<double>(type: "float", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                }); 
        }

        protected override void Down(MigrationBuilder migrationBuilder)    // Down method can drop table . can perfrom rollback on migrations  
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
