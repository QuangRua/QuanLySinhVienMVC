using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Models
{
    public class SinhVien
    {
        [Key]
        public int MaSV { get; set; }

        [Required(ErrorMessage = "Nhập họ tên")]
        [StringLength(100)]
        public string HoTen { get; set; } = string.Empty;

        [Required]
        public string GioiTinh { get; set; } = string.Empty;

        public int Tuoi { get; set; } 

        [Required]
        public string Lop { get; set; } = string.Empty;

        public string DiaChi { get; set; } = string.Empty;
    }
}
