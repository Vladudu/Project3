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
    public class BuildCompletsController : ControllerBase
    {
        private readonly Project3Context _context;

        public BuildCompletsController(Project3Context context)
        {
            _context = context;
        }

        // GET: api/BuildComplets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuildComplet>>> GetBuildComplet()
        {
            return await _context.BuildComplet.ToListAsync();
        }

        // GET: api/BuildComplets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BuildComplet>> GetBuildComplet(Guid id)
        {
            var buildComplet = await _context.BuildComplet.FindAsync(id);

            if (buildComplet == null)
            {
                return NotFound();
            }

            return buildComplet;
        }

        // PUT: api/BuildComplets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuildComplet(Guid id, BuildComplet buildComplet)
        {
            if (id != buildComplet.ID)
            {
                return BadRequest();
            }

            _context.Entry(buildComplet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildCompletExists(id))
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

        // POST: api/BuildComplets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BuildComplet>> PostBuildComplet(BuildComplet buildComplet)
        {
            _context.BuildComplet.Add(buildComplet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuildComplet", new { id = buildComplet.ID }, buildComplet);
        }

        // DELETE: api/BuildComplets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBuildComplet(Guid id)
        {
            var buildComplet = await _context.BuildComplet.FindAsync(id);
            if (buildComplet == null)
            {
                return NotFound();
            }

            _context.BuildComplet.Remove(buildComplet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BuildCompletExists(Guid id)
        {
            return _context.BuildComplet.Any(e => e.ID == id);
        }
    }
}
