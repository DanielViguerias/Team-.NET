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
    public class CuentasController : ControllerBase
    {


        private readonly AplicationDbContext _context;

        public CuentasController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<CuentasController>
        [HttpGet]


        public async Task<ActionResult> Get()
        {



            try
            {
                var listCuentas = await _context.cuenta.ToListAsync();

                return Ok(listCuentas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
        

        // GET api/<CuentasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CuentasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CuentasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CuentasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
