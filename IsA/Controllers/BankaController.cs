using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IsA.Models.Banka;

namespace IsA.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BankaController : ControllerBase
    {
        private readonly DbContextBanka _context;

        public BankaController(DbContextBanka context)
        {
            _context = context;
        }

        // ovo se poziva iz aplikacije
        // GET: api/Bankas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Banka>>> GetBanka()
        //public IEnumerable<Banka>GetBanka()
        {
            //return _context.Banka.ToList();
            return await _context.Banka.Skip(0).Take(5).ToListAsync();
        }

        // ovo se poziva direktno preko adrese
        // GET: api/Bankas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Banka>>> GetBanka(int id)
        {
            return await _context.Banka.Skip(id).Take(5).ToListAsync();
        }
        //public async Task<ActionResult<Banka>> GetBanka(int id)
        //{
        //    var banka = await _context.Banka.FindAsync(id);

        //    if (banka == null)
        //    {
        //        return NotFound();
        //    }

        //    return banka;
        //}

        // PUT: api/Bankas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBanka(int id, Banka banka)
        {
            if (id != banka.Id)
            {
                return BadRequest();
            }

            _context.Entry(banka).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankaExists(id))
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

        // POST: api/Bankas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Banka>> PostBanka(Banka banka)
        {
            _context.Banka.Add(banka);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBanka", new { id = banka.Id }, banka);
        }

        // DELETE: api/Bankas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Banka>> DeleteBanka(int id)
        {
            var banka = await _context.Banka.FindAsync(id);
            if (banka == null)
            {
                return NotFound();
            }

            _context.Banka.Remove(banka);
            await _context.SaveChangesAsync();

            return banka;
        }

        private bool BankaExists(int id)
        {
            return _context.Banka.Any(e => e.Id == id);
        }
    }
}
