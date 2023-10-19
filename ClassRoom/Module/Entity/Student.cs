using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassRoom.Module.Entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
