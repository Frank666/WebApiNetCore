using AutoMapper;
using api_ef.DTOs.Character;
using api_ef.Models;

namespace api_ef
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }

    }
}