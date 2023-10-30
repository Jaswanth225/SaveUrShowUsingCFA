using Microsoft.EntityFrameworkCore.Migrations;

namespace SaveUrShowUsingCFA.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usertype",
                table: "Registration");

            migrationBuilder.AddColumn<int>(
                name: "contact",
                table: "Registration",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contact",
                table: "Registration");

            migrationBuilder.AddColumn<string>(
                name: "usertype",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
