using Microsoft.EntityFrameworkCore.Migrations;

namespace CVProject.DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Experiences",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Abouts",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Experiences");

            migrationBuilder.AlterColumn<short>(
                name: "Phone",
                table: "Abouts",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
