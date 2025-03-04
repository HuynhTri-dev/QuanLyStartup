using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyStartup.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hashtag",
                columns: table => new
                {
                    IDHashtag = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHashtag = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtag", x => x.IDHashtag);
                });

            migrationBuilder.CreateTable(
                name: "LinhVuc",
                columns: table => new
                {
                    IDLinhVuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLinhVuc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhVuc", x => x.IDLinhVuc);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    IDNguoiDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.IDNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "Startup",
                columns: table => new
                {
                    IDStartup = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenStartup = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IDLinhVuc = table.Column<int>(type: "int", nullable: true),
                    MucTieu = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PhanTramCoPhan = table.Column<double>(type: "float", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiXetDuyet = table.Column<int>(type: "int", nullable: false),
                    IDNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Startup", x => x.IDStartup);
                    table.ForeignKey(
                        name: "FK_Startup_LinhVuc_IDLinhVuc",
                        column: x => x.IDLinhVuc,
                        principalTable: "LinhVuc",
                        principalColumn: "IDLinhVuc",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Startup_NguoiDung_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    IDNoti = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayGui = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.IDNoti);
                    table.ForeignKey(
                        name: "FK_ThongBao_NguoiDung_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TinNhan",
                columns: table => new
                {
                    IDTinNhan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IDNguoiGui = table.Column<int>(type: "int", nullable: true),
                    IDNguoiNhan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinNhan", x => x.IDTinNhan);
                    table.ForeignKey(
                        name: "FK_TinNhan_NguoiDung_IDNguoiGui",
                        column: x => x.IDNguoiGui,
                        principalTable: "NguoiDung",
                        principalColumn: "IDNguoiDung");
                    table.ForeignKey(
                        name: "FK_TinNhan_NguoiDung_IDNguoiNhan",
                        column: x => x.IDNguoiNhan,
                        principalTable: "NguoiDung",
                        principalColumn: "IDNguoiDung");
                });

            migrationBuilder.CreateTable(
                name: "TinTuc",
                columns: table => new
                {
                    IDTinTuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinTuc", x => x.IDTinTuc);
                    table.ForeignKey(
                        name: "FK_TinTuc_NguoiDung_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaStartup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiemDanhGia = table.Column<int>(type: "int", nullable: false),
                    NhanXet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDStartup = table.Column<int>(type: "int", nullable: false),
                    IDNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaStartup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DanhGiaStartup_NguoiDung_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGiaStartup_Startup_IDStartup",
                        column: x => x.IDStartup,
                        principalTable: "Startup",
                        principalColumn: "IDStartup");
                });

            migrationBuilder.CreateTable(
                name: "GiayTo",
                columns: table => new
                {
                    IDGiayTo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileGiayTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenGiayTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDStartup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiayTo", x => x.IDGiayTo);
                    table.ForeignKey(
                        name: "FK_GiayTo_Startup_IDStartup",
                        column: x => x.IDStartup,
                        principalTable: "Startup",
                        principalColumn: "IDStartup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HopDongDauTu",
                columns: table => new
                {
                    IDHopDong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnhXacNhan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgayKyKet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhanTramLoiNhuan = table.Column<double>(type: "float", nullable: true),
                    IDStartup = table.Column<int>(type: "int", nullable: false),
                    IDNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDongDauTu", x => x.IDHopDong);
                    table.ForeignKey(
                        name: "FK_HopDongDauTu_NguoiDung_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HopDongDauTu_Startup_IDStartup",
                        column: x => x.IDStartup,
                        principalTable: "Startup",
                        principalColumn: "IDStartup");
                });

            migrationBuilder.CreateTable(
                name: "TinTucHashtag",
                columns: table => new
                {
                    IDTinTuc = table.Column<int>(type: "int", nullable: false),
                    IDHashtag = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinTucHashtag", x => new { x.IDTinTuc, x.IDHashtag });
                    table.ForeignKey(
                        name: "FK_TinTucHashtag_Hashtag_IDHashtag",
                        column: x => x.IDHashtag,
                        principalTable: "Hashtag",
                        principalColumn: "IDHashtag",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TinTucHashtag_TinTuc_IDTinTuc",
                        column: x => x.IDTinTuc,
                        principalTable: "TinTuc",
                        principalColumn: "IDTinTuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaStartup_IDNguoiDung",
                table: "DanhGiaStartup",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaStartup_IDStartup",
                table: "DanhGiaStartup",
                column: "IDStartup");

            migrationBuilder.CreateIndex(
                name: "IX_GiayTo_IDStartup",
                table: "GiayTo",
                column: "IDStartup");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongDauTu_IDNguoiDung",
                table: "HopDongDauTu",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongDauTu_IDStartup",
                table: "HopDongDauTu",
                column: "IDStartup");

            migrationBuilder.CreateIndex(
                name: "IX_Startup_IDLinhVuc",
                table: "Startup",
                column: "IDLinhVuc");

            migrationBuilder.CreateIndex(
                name: "IX_Startup_IDNguoiDung",
                table: "Startup",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_ThongBao_IDNguoiDung",
                table: "ThongBao",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_TinNhan_IDNguoiGui",
                table: "TinNhan",
                column: "IDNguoiGui");

            migrationBuilder.CreateIndex(
                name: "IX_TinNhan_IDNguoiNhan",
                table: "TinNhan",
                column: "IDNguoiNhan");

            migrationBuilder.CreateIndex(
                name: "IX_TinTuc_IDNguoiDung",
                table: "TinTuc",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_TinTucHashtag_IDHashtag",
                table: "TinTucHashtag",
                column: "IDHashtag");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhGiaStartup");

            migrationBuilder.DropTable(
                name: "GiayTo");

            migrationBuilder.DropTable(
                name: "HopDongDauTu");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "TinNhan");

            migrationBuilder.DropTable(
                name: "TinTucHashtag");

            migrationBuilder.DropTable(
                name: "Startup");

            migrationBuilder.DropTable(
                name: "Hashtag");

            migrationBuilder.DropTable(
                name: "TinTuc");

            migrationBuilder.DropTable(
                name: "LinhVuc");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
