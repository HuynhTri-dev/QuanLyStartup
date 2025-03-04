using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyStartup.Models
{
    [Table("LinhVuc")]
    public class LinhVuc
    {
        [Key]
        public int IDLinhVuc { get; set; }

        [Required, MaxLength(255)]
        public string TenLinhVuc { get; set; } = string.Empty;

        // Quan hệ 1-N với Startup
        public ICollection<Startup> Startups { get; set; } = new List<Startup>();
    }
}
