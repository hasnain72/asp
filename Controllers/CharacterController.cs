using demo.Models;
using demo.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Dtos.Character;
namespace demo.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {

        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character{ Id=4 , Name= "sam"}
        };
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacter());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
       
             return Ok(await _characterService.GetCharacterById(id));

        }
        [HttpPost]
        public async Task<IActionResult> AddCharacters(AddCharacterDto newCharacter)
        {

            
            return Ok(await _characterService.AddCharacter(newCharacter));

        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {

            ServiceResponse<GetCharacterDto> response =await _characterService.UpdateCharacter(updateCharacter);
            if(response.Data==null){
                return NotFound(response);
            }
            return Ok(response);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
       
             ServiceResponse<List<GetCharacterDto>> response =await _characterService.DeleteCharacter(id);
            if(response.Data==null){
                return NotFound(response);
            }
            return Ok(response);

        }
    }
}
