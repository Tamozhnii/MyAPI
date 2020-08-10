using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public string Name { get; set; }

        public bool Base { get; set; }
    }
}
