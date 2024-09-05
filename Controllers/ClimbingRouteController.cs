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
    public class ClimbingRouteController: ControllerBase
    {
        private readonly AppDbContext _context;
        public ClimbingRouteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/crazyhorses
        [HttpGet]
            public async Task<ActionResult<IEnumerable<Massive>>> GetClimbingRoutes()
        {
            var climbingroutes = await _context.ClimbingRoutes
                .Include(cr => cr.Sector)
                //.AsNoTracking()
                .ToListAsync();
            return Ok(climbingroutes);       
        }


        //GET: api/crazyhorses/5
        [HttpGet("{id}")]
            public async Task<ActionResult<ClimbingRoute>> GetClimbingRoute(int id)
        {
            var climbingroute = await _context.ClimbingRoutes
            .Include(cr => cr.Sector)
            .AsNoTracking()
            .FirstOrDefaultAsync(cr => cr.ClimbingRouteId == id);

            if(climbingroute == null)
            {
                return NotFound();
            }
            return Ok(climbingroute);
        }


        //POST: api/climbingroutes
        [HttpPost]
            public async Task<ActionResult<ClimbingRoute>> CreateClimbingRoute(ClimbingRoute climbingroute)
        {
            _context.ClimbingRoutes.Add(climbingroute);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClimbingRoute),
            new{id = climbingroute.ClimbingRouteId}, climbingroute);
        }


        //PUT
        [HttpPut("{id}")]
            public async Task<ActionResult> UpdateClimbingRoute(int id, ClimbingRoute climbingroute)
        {
            if (id != climbingroute.ClimbingRouteId)
            {
                return BadRequest("ClimbingRoute ID mismatch");
            }
            _context.Entry(climbingroute).State = EntityState.Modified;

            try 
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            { if (!ClimbingRouteExists(id))
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
            public async Task<IActionResult> DeleteClimbingRoute(int id)
        {
            var climbingroute = await _context.ClimbingRoutes.FindAsync(id);
            if (climbingroute == null)
            {
                return NotFound();
            }

            _context.ClimbingRoutes.Remove(climbingroute);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClimbingRouteExists(int id)
        {
            return _context.ClimbingRoutes.Any(c => c.ClimbingRouteId == id);
        }  


    }
}