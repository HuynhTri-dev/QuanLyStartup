﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyStartup.Models
{

    [Table("HopDongDauTu")]
    public class HopDongDauTu
    {
        [Key]
        public int IDHopDong { get; set; }

        [MaxLength(int.MaxValue)]
        public string? AnhXacNhan { get; set; }

        public DateTime? NgayKyKet { get; set; }

        [Required]
        public decimal TongTien { get; set; }

        public double? PhanTramLoiNhuan { get; set; }

        [MaxLength(int.MaxValue)]
        public string? NoiDungHopDong { get; set; }

        public string TrangThai { get; set; }

        // Khóa ngoại
        public int IDStartup { get; set; }
        [ForeignKey("IDStartup")]
        public Startup? Startup { get; set; }

        public int IDNguoiDung { get; set; }
        [ForeignKey("IDNguoiDung")]
        public NguoiDung? NguoiDung { get; set; }
    }
}
