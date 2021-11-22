using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MVCMovie.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<MatHang> MatHangs { get; set;}

    }
}