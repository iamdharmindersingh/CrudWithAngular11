using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithAngular11.Models
{
    public class StudentDetail
    {
        [Key]
        public int StudentID { get; set; }
        [Column(TypeName ="varchar(150)")]
        public string StudentName { get; set; }
        [Column(TypeName ="int")]
        public int Age { get; set; }
        [Column(TypeName ="varchar(150)")]
        public string Address { get; set; }
    } 
}
