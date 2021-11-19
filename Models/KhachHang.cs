using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCMovie.Models
{
    public class KhachHang : Person
    {
        public string IDKhachHang { get; set; }
        public string TenKhachHang { get; set; }

    }
}