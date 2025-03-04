﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyStartup.Migrations
{
    /// <inheritdoc />
    public partial class DbRiskChance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "NguoiDung",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "NguoiDung");
        }
    }
}
