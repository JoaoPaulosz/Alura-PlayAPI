using Alura_Play.Data.Dtos;
using Alura_Play.Models;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Alura_Play.Profiles
{
    public class PlayProfile : Profile
    {
        public PlayProfile()
        {
            CreateMap<CreatePlayDto, Play>();
        }
    }
}
