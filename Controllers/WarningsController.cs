using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TagMemberAPI.Data;

namespace TagMemberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarningsController : ControllerBase
    {
        private readonly TAGMemberAPIContext _context;

        public WarningsController(TAGMemberAPIContext context)
        {
            _context = context;
        }

        // GET: api/Warnings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Warning>>> GetWarnings()
        {
            return await _context.Warnings.ToListAsync();
        }

        // GET: api/Warnings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Warning>> GetWarning(int id)
        {
            var warning = await _context.Warnings.FindAsync(id);

            if (warning == null)
            {
                return NotFound();
            }

            return warning;
        }

        // PUT: api/Warnings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWarning(int id, Warning warning)
        {
            if (id != warning.ID)
            {
                return BadRequest();
            }

            _context.Entry(warning).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WarningExists(id))
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

        // POST: api/Warnings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Warning>> PostWarning(Warning warning)
        {
            _context.Warnings.Add(warning);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWarning", new { id = warning.ID }, warning);
        }

        // DELETE: api/Warnings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWarning(int id)
        {
            var warning = await _context.Warnings.FindAsync(id);
            if (warning == null)
            {
                return NotFound();
            }

            _context.Warnings.Remove(warning);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WarningExists(int id)
        {
            return _context.Warnings.Any(e => e.ID == id);
        }
    }
}
