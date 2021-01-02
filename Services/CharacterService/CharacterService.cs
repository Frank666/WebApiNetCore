using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using api_ef.Models;

namespace api_ef.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Name = "Fideo", Id = 666}
        };
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;

        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(x => x.Id == id);
        }
    }
}