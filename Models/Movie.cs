using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCMovie.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public string MovieID { get; set; }
        public string MovieName { get; set; }

    }
}