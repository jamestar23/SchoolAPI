using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentEntryController : ControllerBase
    {
        private readonly SchoolContext _context;

        public EnrollmentEntryController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/EnrollmentEntry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnrollmentEntry>>> GetEnrollmentEntries()
        {
            return await _context.EnrollmentEntries.ToListAsync();
        }

        // GET: api/EnrollmentEntry/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnrollmentEntry>> GetEnrollmentEntry(int id)
        {
            var enrollmentEntry = await _context.EnrollmentEntries.FindAsync(id);

            if (enrollmentEntry == null)
            {
                return NotFound();
            }

            return enrollmentEntry;
        }

        // PUT: api/EnrollmentEntry/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrollmentEntry(int id, EnrollmentEntry enrollmentEntry)
        {
            if (id != enrollmentEntry.Id)
            {
                return BadRequest();
            }

            _context.Entry(enrollmentEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrollmentEntryExists(id))
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

        // POST: api/EnrollmentEntry
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EnrollmentEntry>> PostEnrollmentEntry(EnrollmentEntry enrollmentEntry)
        {
            _context.EnrollmentEntries.Add(enrollmentEntry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnrollmentEntry", new { id = enrollmentEntry.Id }, enrollmentEntry);
        }

        // DELETE: api/EnrollmentEntry/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EnrollmentEntry>> DeleteEnrollmentEntry(int id)
        {
            var enrollmentEntry = await _context.EnrollmentEntries.FindAsync(id);
            if (enrollmentEntry == null)
            {
                return NotFound();
            }

            _context.EnrollmentEntries.Remove(enrollmentEntry);
            await _context.SaveChangesAsync();

            return enrollmentEntry;
        }

        private bool EnrollmentEntryExists(int id)
        {
            return _context.EnrollmentEntries.Any(e => e.Id == id);
        }
    }
}
