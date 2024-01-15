using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BucurPaulaNuria_Proiect.Migrations
{
    /// <inheritdoc />
    public partial class init_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Job",
                table: "Job");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
