using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCMovie.Models
{
    [Table("sps")]
    public class sp
    {
        [Key]
        public string spID { get; set; }
        public string spName { get; set; }

    }
}