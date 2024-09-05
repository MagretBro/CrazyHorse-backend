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
    public class RegionController: ControllerBase
    {
        private readonly AppDbContext _context;
        public RegionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/crazyhorses
        [HttpGet]
                public async Task<ActionResult<IEnumerable<Massive>>> GetRegions()
        {
            var regions = await _context.Regions
                .Include(s => s.Massives)
                //.AsNoTracking()
                .ToListAsync();
            return Ok(regions);       
        }

        //GET: api/crazyhorses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Region>> 
        GetRegion(int id)
            {
                var region = await _context.Regions
                .Include(s => s.Massives)
                //.AsNoTracking()
                .FirstOrDefaultAsync(s => s.RegionId == id);

                if(region == null)
                {
                    return NotFound();
                }
                return Ok(region);
            }

        //POST: api/regions
        [HttpPost]
        public async Task<ActionResult<Region>>
        CreateRegion(Region region)
            {
                _context.Regions.Add(region);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetRegion),
                new{id = region.RegionId}, region);
            }

        //PUT
        [HttpPut("{id}")]
        public async Task<ActionResult>
        UpdateRegion(int id, Region region)
        {
            if (id != region.RegionId)
            {
                return BadRequest("Region ID mismatch");
            }
            _context.Entry(region).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
                { if (!RegionExists(id))
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
                public async Task<IActionResult> DeleteRegion(int id)
                {
                    var region = await _context.Regions.FindAsync(id);
                    if (region == null)
                    {
                        return NotFound();
                    }

                    _context.Regions.Remove(region);
                    await _context.SaveChangesAsync();

                    return NoContent();
                }

                private bool RegionExists(int id)
                {
                    return _context.Regions.Any(s => s.RegionId == id);
                }  


    }
}