using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCMovie.Models
{
    [Table("MatHangs")]
    public class MatHang
    {
        [Key]
        public string IDMatHang { get; set; }
        public string TenMatHang { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set;}

    }
}