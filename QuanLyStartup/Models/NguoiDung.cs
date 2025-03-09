using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyStartup.Models
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        public int IDNguoiDung { get; set; }

        [Required, MaxLength(255)]
        public string HoTen { get; set; } = string.Empty;

        [MaxLength(int.MaxValue)]
        public string AvatarUrl { get; set; } = "~/assets/user/image.png"; // Đường dẫn mặc định

        [Required, MaxLength(int.MaxValue), EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(int.MaxValue)]
        public string MatKhau { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string VaiTro { get; set; } = string.Empty;

        public DateTime NgayTao { get; set; } = DateTime.Now;

        // Quan hệ 1-N
        public ICollection<Startup> Startups { get; set; } = new List<Startup>();
        public ICollection<HopDongDauTu> HopDongDauTus { get; set; } = new List<HopDongDauTu>();

    }
}
