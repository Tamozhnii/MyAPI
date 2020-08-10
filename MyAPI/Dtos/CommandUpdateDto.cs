using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Dtos
{
    public class CommandUpdateDto
    {
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
