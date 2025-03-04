﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyStartup.Models
{

    [Table("Startup")]
    public class Startup
    {
        [Key]
        public int IDStartup { get; set; }

        [Required, MaxLength(255)]
        public string TenStartup { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? MoTa { get; set; }

        // Cập nhật IDLinhVuc để nullable
        public int? IDLinhVuc { get; set; }  // Đã sửa thành int? để hỗ trợ SetNull

        [ForeignKey("IDLinhVuc")]
        public LinhVuc? LinhVuc { get; set; }

        public decimal? MucTieu { get; set; }
        public double? PhanTramCoPhan { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;

        [Required]
        public TrangThaiXetDuyetEnum TrangThaiXetDuyet { get; set; } = TrangThaiXetDuyetEnum.ChoDuyet;

        // Khóa ngoại
        public int IDNguoiDung { get; set; }

        [ForeignKey("IDNguoiDung")]
        public NguoiDung? NguoiDung { get; set; }

        // Quan hệ 1 - N với GiayTo
        public ICollection<GiayTo> GiayTos { get; set; } = new List<GiayTo>();
        public ICollection<HopDongDauTu> HopDongDauTus { get; set; } = new List<HopDongDauTu>();

    }
    public enum TrangThaiXetDuyetEnum
    {
        ChoDuyet = 0,
        DaDuyet = 1,
        TuChoi = 2
    }
}
