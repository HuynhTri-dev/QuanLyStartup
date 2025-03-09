using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyStartup.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailConfirmation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "XacThucEmail",
                table: "NguoiDung",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XacThucEmail",
                table: "NguoiDung");
        }
    }
}
