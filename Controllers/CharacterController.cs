using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_ef.Services.CharacterService;
using api_ef.Models;

namespace api_ef.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            this._characterService = characterService;

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await this._characterService.GetAllCharacters());
        }

        [HttpGet]
        [Route("GetSingle/{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await this._characterService.GetCharacterById(id));
        }

        [HttpPost]
        [Route("AddCharacter")]
        public async Task<IActionResult> AddCharacter(Character character)
        {
            if (character.Id != 0)
            {
                return Ok(await this._characterService.AddCharacter(character));
            }
            return Ok(new { result = "please provide an ID :)" });
        }

    }
}