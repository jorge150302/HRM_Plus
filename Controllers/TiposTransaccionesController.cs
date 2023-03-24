using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HRM_Plus.Data;
using HRM_Plus.Models;

namespace HRM_Plus.Controllers
{
    public class TiposTransaccionesController : Controller
    {
        private readonly HRM_PlusContext _context;

        public TiposTransaccionesController(HRM_PlusContext context)
        {
            _context = context;
        }

        // GET: TiposTransacciones
        public async Task<IActionResult> Index()
        {
              return _context.TipoTransaccion != null ? 
                          View(await _context.TipoTransaccion.ToListAsync()) :
                          Problem("Entity set 'HRM_PlusContext.TipoTransaccion'  is null.");
        }

        // GET: TiposTransacciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoTransaccion == null)
            {
                return NotFound();
            }

            var tipoTransaccion = await _context.TipoTransaccion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoTransaccion == null)
            {
                return NotFound();
            }

            return View(tipoTransaccion);
        }

        // GET: TiposTransacciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposTransacciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreTipoTransaccíon,DescripcionTipoTransaccion,isActivo")] TipoTransaccion tipoTransaccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoTransaccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoTransaccion);
        }

        // GET: TiposTransacciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoTransaccion == null)
            {
                return NotFound();
            }

            var tipoTransaccion = await _context.TipoTransaccion.FindAsync(id);
            if (tipoTransaccion == null)
            {
                return NotFound();
            }
            return View(tipoTransaccion);
        }

        // POST: TiposTransacciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreTipoTransaccíon,DescripcionTipoTransaccion,isActivo")] TipoTransaccion tipoTransaccion)
        {
            if (id != tipoTransaccion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoTransaccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoTransaccionExists(tipoTransaccion.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tipoTransaccion);
        }

        // GET: TiposTransacciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoTransaccion == null)
            {
                return NotFound();
            }

            var tipoTransaccion = await _context.TipoTransaccion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoTransaccion == null)
            {
                return NotFound();
            }

            return View(tipoTransaccion);
        }

        // POST: TiposTransacciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TipoTransaccion == null)
            {
                return Problem("Entity set 'HRM_PlusContext.TipoTransaccion'  is null.");
            }
            var tipoTransaccion = await _context.TipoTransaccion.FindAsync(id);
            if (tipoTransaccion != null)
            {
                _context.TipoTransaccion.Remove(tipoTransaccion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoTransaccionExists(int id)
        {
          return (_context.TipoTransaccion?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
