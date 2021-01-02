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
        public IActionResult Get()
        {
            return Ok(this._characterService.GetAllCharacters());
        }

        [HttpGet]
        [Route("GetSingle/{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(this._characterService.GetCharacterById(id));
        }

        [HttpPost]
        [Route("AddCharacter")]
        public IActionResult AddCharacter(Character character)
        {
            if (character.Id != 0)
            {
                return Ok(this._characterService.AddCharacter(character));
            }
            return Ok(new { result = "please provide an ID :)" });
        }

    }
}