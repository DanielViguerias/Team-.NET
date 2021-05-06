using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {

        private readonly AplicationDbContext _context;

        public MovimientosController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<MovimientosController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {



            try
            {
                var listMovimientos = await _context.movimiento.ToListAsync();

                return Ok(listMovimientos);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        // GET api/<MovimientosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MovimientosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovimientosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovimientosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
