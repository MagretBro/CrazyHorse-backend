using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backcrazyhorse.Data;
using Backcrazyhorse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backcrazyhorse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // api/countrycontroller
    public class CountryController:ControllerBase
    {
        private readonly AppDbContext _context;
        public CountryController(AppDbContext context)
        {
            _context=context;
        }


        // GET: api/countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
            var countries = await _context.Countries
                .Include(c => c.Regions)
                //.AsNoTracking()
                .ToListAsync();
            return Ok(countries);

        }

        // GET: api/crazyhorses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
                var country = await _context.Countries
                .Include(c=> c.Regions)
                //.AsNoTracking()
                .FirstOrDefaultAsync(c => c.CountryId == id);

                if(country == null)
                {
                    return NotFound();
                }
                return Ok(country);
        }

        // POST: api/countries
        [HttpPost]
        public async Task<ActionResult<Country>>
        CreateCountry(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCountry), new {id = country.CountryId}, country);
        }

        //PUT
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCountry(int id, Country country)
                {
                    if (id != country.CountryId)
                    {
                        return BadRequest("Country ID mismatch");
                    }
                    _context.Entry(country).State = EntityState.Modified;

                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CountryExists(id))
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

                //DELETE
                [HttpDelete("{id}")]
                public async Task<IActionResult> DeleteCountry(int id)
                {
                    var country = await _context.Countries.FindAsync(id);
                    if (country == null)
                    {
                        return NotFound();
                    }

                    _context.Countries.Remove(country);
                    await _context.SaveChangesAsync();

                    return NoContent();
                }

                private bool CountryExists(int id)
                {
                    return _context.Countries.Any(e => e.CountryId == id);
                }       
    }
}