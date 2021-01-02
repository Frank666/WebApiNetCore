using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_ef.Services.CharacterService;
using api_ef.Models;
using api_ef.DTOs.Character;

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
        public async Task<IActionResult> AddCharacter(AddCharacterDto character)
        {
            return Ok(await this._characterService.AddCharacter(character));
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {
            return Ok(await this._characterService.UpdateCharacter(updateCharacter));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            return Ok(await this._characterService.DeleteCharacter(id));
        }

    }
}