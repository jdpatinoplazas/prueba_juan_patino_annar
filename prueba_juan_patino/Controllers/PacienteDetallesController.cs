using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba_juan_patino.Models;

namespace prueba_juan_patino.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteDetallesController : ControllerBase
    {
        private readonly PacienteDetalleContext _context;

        public PacienteDetallesController(PacienteDetalleContext context)
        {
            _context = context;
        }

        // GET: api/PacienteDetalles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PacienteDetalle>>> GetPacienteDetalles()
        {
          if (_context.PacienteDetalles == null)
          {
              return NotFound();
          }
            return await _context.PacienteDetalles.ToListAsync();
        }

        // GET: api/PacienteDetalles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteDetalle>> GetPacienteDetalle(int id)
        {
          if (_context.PacienteDetalles == null)
          {
              return NotFound();
          }
            var pacienteDetalle = await _context.PacienteDetalles.FindAsync(id);

            if (pacienteDetalle == null)
            {
                return NotFound();
            }

            return pacienteDetalle;
        }

        // PUT: api/PacienteDetalles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPacienteDetalle(int id, PacienteDetalle pacienteDetalle)
        {
            if (id != pacienteDetalle.PacienteDetalleId)
            {
                return BadRequest();
            }

            _context.Entry(pacienteDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PacienteDetalleExists(id))
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

        // POST: api/PacienteDetalles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PacienteDetalle>> PostPacienteDetalle(PacienteDetalle pacienteDetalle)
        {
          if (_context.PacienteDetalles == null)
          {
              return Problem("Entity set 'PacienteDetalleContext.PacienteDetalles'  is null.");
          }
            _context.PacienteDetalles.Add(pacienteDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPacienteDetalle", new { id = pacienteDetalle.PacienteDetalleId }, pacienteDetalle);
        }

        // DELETE: api/PacienteDetalles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePacienteDetalle(int id)
        {
            if (_context.PacienteDetalles == null)
            {
                return NotFound();
            }
            var pacienteDetalle = await _context.PacienteDetalles.FindAsync(id);
            if (pacienteDetalle == null)
            {
                return NotFound();
            }

            _context.PacienteDetalles.Remove(pacienteDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PacienteDetalleExists(int id)
        {
            return (_context.PacienteDetalles?.Any(e => e.PacienteDetalleId == id)).GetValueOrDefault();
        }
    }
}
