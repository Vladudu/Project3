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
    public class AngajatisController : ControllerBase
    {
        private readonly Project3Context _context;

        public AngajatisController(Project3Context context)
        {
            _context = context;
        }

        // GET: api/Angajatis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Angajati>>> GetAngajati()
        {
            return await _context.Angajati.ToListAsync();
        }

        // GET: api/Angajatis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Angajati>> GetAngajati(Guid id)
        {
            var angajati = await _context.Angajati.FindAsync(id);

            if (angajati == null)
            {
                return NotFound();
            }

            return angajati;
        }

        // PUT: api/Angajatis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAngajati(Guid id, Angajati angajati)
        {
            if (id != angajati.ID)
            {
                return BadRequest();
            }

            _context.Entry(angajati).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AngajatiExists(id))
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

        // POST: api/Angajatis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Angajati>> PostAngajati(Angajati angajati)
        {
            _context.Angajati.Add(angajati);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAngajati", new { id = angajati.ID }, angajati);
        }

        // DELETE: api/Angajatis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAngajati(Guid id)
        {
            var angajati = await _context.Angajati.FindAsync(id);
            if (angajati == null)
            {
                return NotFound();
            }

            _context.Angajati.Remove(angajati);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AngajatiExists(Guid id)
        {
            return _context.Angajati.Any(e => e.ID == id);
        }
    }
}
