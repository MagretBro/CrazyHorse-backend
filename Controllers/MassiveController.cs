using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Backcrazyhorse.Data;
using Backcrazyhorse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backcrazyhorse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MassiveController: ControllerBase
    {
        private readonly AppDbContext _context;
        public MassiveController(AppDbContext context)
        {
            _context = context;
        }


        // Massive
        // GET: api/crazyhorses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Massive>>> GetMassives()
        {
            var massives = await _context.Massives
                .Include(c => c.Sectors)
                .AsNoTracking()
                .ToListAsync();
            return Ok(massives);        
        }

        //GET: api/crazyhorses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Massive>> GetMassive(int id)
            {
                var massive = await _context.Massives
                .Include(m => m.Sectors)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.MassiveId == id);

                if(massive == null)
                {
                    return NotFound();
                }
                return Ok(massive);
            }

        //POST: api/massives
        [HttpPost]
        public async Task<ActionResult<Massive>>
        CreateMassive(Massive massive)
            {
                _context.Massives.Add(massive);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetMassive),
                new{id = massive.MassiveId}, massive)
            }

        //PUT
        [HttpPut("{id}")]
        public async Task<ActionResult>
        UpdateMassive(int id, Massive massive)
        {
            if (id != massive.MassiveId)
            {
                return BadRequest("Massive ID mismatch");
            }
            _context.Entry(massive).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
                { if (!MassiveExists(id))
                    {
                        return NotFound();
                    }
                    else 
                    { throw; }
                }
                return NoContent();
        }

         //DELETE
                [HttpDelete("{id}")]
                public async Task<IActionResult> DeleteMassive(int id)
                {
                    var massive = await _context.Massives.FindAsync(id);
                    if (massive == null)
                    {
                        return NotFound();
                    }

                    _context.Massives.Remove(massive);
                    await _context.SaveChangesAsync();

                    return NoContent();
                }

                private bool MassiveExists(int id)
                {
                    return _context.Massives.Any(e => e.MassiveId == id);
                }       
    }
}