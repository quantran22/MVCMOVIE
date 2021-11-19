using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCMovie.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }

    }
}