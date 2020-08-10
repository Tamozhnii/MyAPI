using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyAPI.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Base { get; set; }
    }
}
