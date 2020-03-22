using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyPortfoliosController : ControllerBase
    {
        private readonly DataContext _context;

        public MyPortfoliosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/MyPortfolios
        [HttpGet]
        public IEnumerable<MyPortfolio> GetMyPortfolios()
        {
            return _context.MyPortfolios;
        }

        // GET: api/MyPortfolios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMyPortfolio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var myPortfolio = await _context.MyPortfolios.FindAsync(id);

            if (myPortfolio == null)
            {
                return NotFound();
            }

            return Ok(myPortfolio);
        }

        // PUT: api/MyPortfolios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyPortfolio([FromRoute] int id, [FromBody] MyPortfolio myPortfolio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != myPortfolio.Id)
            {
                return BadRequest();
            }

            _context.Entry(myPortfolio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyPortfolioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MyPortfolios
        [HttpPost]
        public async Task<IActionResult> PostMyPortfolio([FromBody] MyPortfolio myPortfolio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MyPortfolios.Add(myPortfolio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMyPortfolio", new { id = myPortfolio.Id }, myPortfolio);
        }

        // DELETE: api/MyPortfolios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyPortfolio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var myPortfolio = await _context.MyPortfolios.FindAsync(id);
            if (myPortfolio == null)
            {
                return NotFound();
            }

            _context.MyPortfolios.Remove(myPortfolio);
            await _context.SaveChangesAsync();

            return Ok(myPortfolio);
        }

        private bool MyPortfolioExists(int id)
        {
            return _context.MyPortfolios.Any(e => e.Id == id);
        }
    }
}