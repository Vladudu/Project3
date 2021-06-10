using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect3.Models;
using Project3.Data;

namespace Project3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagazinsController : ControllerBase
    {
        private readonly Project3Context _context;

        public MagazinsController(Project3Context context)
        {
            _context = context;
        }

        // GET: api/Magazins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Magazin>>> GetMagazin()
        {
            return await _context.Magazin.ToListAsync();
        }

        // GET: api/Magazins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Magazin>> GetMagazin(Guid id)
        {
            var magazin = await _context.Magazin.FindAsync(id);

            if (magazin == null)
            {
                return NotFound();
            }

            return magazin;
        }

        // PUT: api/Magazins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMagazin(Guid id, Magazin magazin)
        {
            if (id != magazin.ID)
            {
                return BadRequest();
            }

            _context.Entry(magazin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MagazinExists(id))
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

        // POST: api/Magazins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Magazin>> PostMagazin(Magazin magazin)
        {
            _context.Magazin.Add(magazin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMagazin", new { id = magazin.ID }, magazin);
        }

        // DELETE: api/Magazins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMagazin(Guid id)
        {
            var magazin = await _context.Magazin.FindAsync(id);
            if (magazin == null)
            {
                return NotFound();
            }

            _context.Magazin.Remove(magazin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MagazinExists(Guid id)
        {
            return _context.Magazin.Any(e => e.ID == id);
        }
    }
}
