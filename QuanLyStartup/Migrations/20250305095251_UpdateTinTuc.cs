using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyStartup.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTinTuc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgTinTuc",
                table: "TinTuc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgTinTuc",
                table: "TinTuc");
        }
    }
}
