using AutoMapper;
using MyAPI.Dtos;
using MyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<CommandCreateDto, Command>(); //POST
            CreateMap<Command, CommandReadDto>(); //GET
            CreateMap<CommandUpdateDto, Command>(); //PUT
            CreateMap<Command, CommandUpdateDto>(); //PATCH
        }
    }
}
