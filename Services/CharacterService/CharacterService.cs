using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using api_ef.Models;
using api_ef.DTOs.Character;
using AutoMapper;

namespace api_ef.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        public CharacterService(IMapper mapper)
        {
            this._mapper = mapper;
        }
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Name = "Fideo", Id = 666}
        };
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            var Character = _mapper.Map<Character>(newCharacter);
            Character.Id = characters.Max(x => x.Id + 1);
            //characters.Add(_mapper.Map<Character>(newCharacter));
            characters.Add(Character);
            serviceResponse.Data = characters.Select(x => _mapper.Map<GetCharacterDto>(x)).ToList();
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(x => _mapper.Map<GetCharacterDto>(x)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(x => x.Id == id));
            return serviceResponse;
        }
    }
}