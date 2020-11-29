using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inmobiliaria.Context;
using Inmobiliaria.Models;

namespace Inmobiliaria.Controllers
{
    public class PublicacionsController : Controller
    {
        private readonly InmobiliariaDatabaseContext _context;

        public PublicacionsController(InmobiliariaDatabaseContext context)
        {
            _context = context;
        }

        // GET: Publicacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Publicaciones.ToListAsync());
        }

        // GET: Publicacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicacion = await _context.Publicaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (publicacion == null)
            {
                return NotFound();
            }

            return View(publicacion);
        }

        public async Task<IActionResult> DetailsInmueble(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inmueble = await _context.Inmuebles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inmueble == null)
            {
                return NotFound();
            }

            return View(inmueble);
        }
        public async Task<IActionResult> DetailsInmueble__(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inmueble = await _context.Inmuebles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inmueble == null)
            {
                return NotFound();
            }

            return View(inmueble);
        }

        // GET: Publicacions/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Publicacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,miIdInmuebe,fechaDePublicacion,cantidadDeVisitas,operacion")] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publicacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publicacion);
        }

        // GET: Publicacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicacion = await _context.Publicaciones.FindAsync(id);
            if (publicacion == null)
            {
                return NotFound();
            }
            return View(publicacion);
        }

        // POST: Publicacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,miIdInmuebe,fechaDePublicacion,cantidadDeVisitas,operacion")] Publicacion publicacion)
        {
            if (id != publicacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publicacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublicacionExists(publicacion.Id))
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
            return View(publicacion);
        }

        // GET: Publicacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicacion = await _context.Publicaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (publicacion == null)
            {
                return NotFound();
            }

            return View(publicacion);
        }

        // POST: Publicacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publicacion = await _context.Publicaciones.FindAsync(id);
            _context.Publicaciones.Remove(publicacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublicacionExists(int id)
        {
            return _context.Publicaciones.Any(e => e.Id == id);
        }

    }
}
