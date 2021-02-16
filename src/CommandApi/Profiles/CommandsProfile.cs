using CommandAPI.DTO;
using CommandAPI.Data;
using AutoMapper;
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandApi.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDTO>();
        }
        
    }
}