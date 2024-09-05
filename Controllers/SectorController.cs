using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backcrazyhorse.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backcrazyhorse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectorController: ControllerBase
    {
        private readonly AppDbContext _context;
        public SectorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/crazyhorses
        [HttpGet]
                public async Task<ActionResult<IEnumerable<Massive>>> GetSectors()
        {
            var sectors = await _context.Sectors
                .Include(s => s.ClimbingRoutes)
                .AsNoTracking()
                .ToListAsync();
            return Ok(sectors);       
        }

        //GET: api/crazyhorses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sector>> 
        GetSector(int id)
            {
                var sector = await _context.Sectors
                .Include(s => s.ClimbingRoutes)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.SectorId == id);

                if(sector == null)
                {
                    return NotFound();
                }
                return Ok(sector);
            }

        //POST: api/sectors
        [HttpPost]
        public async Task<ActionResult<Sector>>
        CreateSector(Sector sector)
            {
                _context.Sectors.Add(sector);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetSector),
                new{id = sector.SectorId}, sector)
            }

        //PUT
        [HttpPut("{id}")]
        public async Task<ActionResult>
        UpdateSector(int id, Sector sector)
        {
            if (id != sector.SectorId)
            {
                return BadRequest("Sector ID mismatch");
            }
            _context.Entry(sector).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
                { if (!SectorExists(id))
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
                public async Task<IActionResult> DeleteSector(int id)
                {
                    var sector = await _context.Sectors.FindAsync(id);
                    if (sector == null)
                    {
                        return NotFound();
                    }

                    _context.Sectors.Remove(sector);
                    await _context.SaveChangesAsync();

                    return NoContent();
                }

                private bool SectorExists(int id)
                {
                    return _context.Sector.Any(s => s.SectorId == id);
                }  


        
    }
}

