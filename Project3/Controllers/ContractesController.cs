using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project3.Data;
using Project3.Models;

namespace Project3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractesController : ControllerBase
    {
        private readonly Project3Context _context;

        public ContractesController(Project3Context context)
        {
            _context = context;
        }

        // GET: api/Contractes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contracte>>> GetContracte()
        {
            return await _context.Contracte.ToListAsync();
        }

        // GET: api/Contractes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contracte>> GetContracte(Guid id)
        {
            var contracte = await _context.Contracte.FindAsync(id);

            if (contracte == null)
            {
                return NotFound();
            }

            return contracte;
        }

        // PUT: api/Contractes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContracte(Guid id, Contracte contracte)
        {
            if (id != contracte.ID)
            {
                return BadRequest();
            }

            _context.Entry(contracte).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContracteExists(id))
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

        // POST: api/Contractes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contracte>> PostContracte(Contracte contracte)
        {
            _context.Contracte.Add(contracte);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContracte", new { id = contracte.ID }, contracte);
        }

        // DELETE: api/Contractes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContracte(Guid id)
        {
            var contracte = await _context.Contracte.FindAsync(id);
            if (contracte == null)
            {
                return NotFound();
            }

            _context.Contracte.Remove(contracte);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContracteExists(Guid id)
        {
            return _context.Contracte.Any(e => e.ID == id);
        }
    }
}
