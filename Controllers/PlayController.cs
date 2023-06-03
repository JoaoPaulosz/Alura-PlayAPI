using Alura_Play.Data.Dtos;
using Alura_Play.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Alura_Play.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayController : ControllerBase
    {
        private Data.PlayContext _context;
        private IMapper _mapper;
        public PlayController(Data.PlayContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult ConsistPlay([FromBody] CreatePlayDto playDto)
        {
            Play play = _mapper.Map<Play>(playDto);
            _context.Add(play);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPlayById),new { Id = play.Id}, play);
        }

        [HttpGet]
        public IActionResult GetPlays()
        {
            return Ok(_context.Plays);
        }
        [HttpGet("{id}")]
        public IActionResult GetPlayById(int id) 
        {
            Play? play = _context.Plays.FirstOrDefault(x => x.Id == id);
            if(play == null)
            {
                return NotFound();
            }
            return Ok(play);
        }
    }
}
