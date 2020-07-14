using Microsoft.EntityFrameworkCore.Migrations;

namespace QL_Vat_Lieu_Xay_Dung_Data_EF.Migrations
{
    public partial class updateslide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Slides",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Slides",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
