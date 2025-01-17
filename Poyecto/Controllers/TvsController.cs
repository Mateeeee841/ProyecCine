using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto;
using Proyecto.Clases;

namespace Poyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvsController : ControllerBase
    {
        private readonly ConexionesDbContext _context;

        public TvsController(ConexionesDbContext context)
        {
            _context = context;
        }

        // GET: api/Tvs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tv>>> Gettvs()
        {
            return await _context.tvs.ToListAsync();
        }

        // GET: api/Tvs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tv>> GetTv(int id)
        {
            var tv = await _context.tvs.FindAsync(id);

            if (tv == null)
            {
                return NotFound();
            }

            return tv;
        }

        // PUT: api/Tvs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTv(int id, Tv tv)
        {
            if (id != tv.id)
            {
                return BadRequest();
            }

            _context.Entry(tv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvExists(id))
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

        // POST: api/Tvs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tv>> PostTv(Tv tv)
        {
            _context.tvs.Add(tv);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTv", new { id = tv.id }, tv);
        }

        // DELETE: api/Tvs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTv(int id)
        {
            var tv = await _context.tvs.FindAsync(id);
            if (tv == null)
            {
                return NotFound();
            }

            _context.tvs.Remove(tv);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TvExists(int id)
        {
            return _context.tvs.Any(e => e.id == id);
        }
    }
}
