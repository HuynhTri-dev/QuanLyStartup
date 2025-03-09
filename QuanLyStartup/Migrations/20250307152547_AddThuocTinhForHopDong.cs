using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyStartup.Migrations
{
    /// <inheritdoc />
    public partial class AddThuocTinhForHopDong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "HopDongDauTu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "HopDongDauTu");
        }
    }
}
