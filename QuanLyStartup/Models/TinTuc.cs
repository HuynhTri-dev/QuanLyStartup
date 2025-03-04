using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyStartup.Models
{
    [Table("TinTuc")]
    public class TinTuc
    {
        [Key]
        public int IDTinTuc { get; set; }

        [Required]
        public string NoiDung { get; set; } = string.Empty;

        public DateTime NgayDang { get; set; } = DateTime.Now;

        public int IDNguoiDung { get; set; }
        [ForeignKey("IDNguoiDung")]
        public NguoiDung? NguoiDung { get; set; }

        public ICollection<TinTucHashtag> TinTucHashtags { get; set; } = new List<TinTucHashtag>();
    }
}
