using Microsoft.AspNetCore.Mvc;
using service.Players.Contract;
using service.Players.Contract.Dto;

namespace Footsal.RestApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _service;
        public PlayerController(PlayerService service)
        {
            _service = service;
        }

        [HttpPost("Set")]
        public void Add([FromBody] PlayerAddDTO dto)
        {
            _service.Add(dto);
        }
        [HttpGet("Get")]
        public List<PlayerGetDTO> Get([FromQuery] PlayerGetDTO dto)
        {
            return _service.GetAll();
        }
        [HttpPatch("update/{id}")]
        public void Update(PlayerUpdateDTO dto, [FromRoute] int id)
        {
            _service.Update(id, dto);
        }
        [HttpDelete("removed/{id}")]
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }
    }
}
