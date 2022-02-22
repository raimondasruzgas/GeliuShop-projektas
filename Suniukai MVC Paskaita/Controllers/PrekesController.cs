#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeliuEshop_projektas.Data;
using GeliuEshop_projektas.Models;

namespace GeliuEshop_projektas.Controllers
{
    public class PrekesController : Controller
    {
        private readonly GeliuEshopDbContext _context;

        public PrekesController(GeliuEshopDbContext context)
        {
            _context = context;
        }

        // GET: Prekes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prekes.ToListAsync());
        }

        // GET: Prekes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preke = await _context.Prekes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preke == null)
            {
                return NotFound();
            }

            return View(preke);
        }

        // GET: Prekes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prekes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vardas,Nuotrauka,Aprasymas,Kaina")] Preke preke)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preke);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(preke);
        }

        // GET: Prekes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preke = await _context.Prekes.FindAsync(id);
            if (preke == null)
            {
                return NotFound();
            }
            return View(preke);
        }

        // POST: Prekes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vardas,Nuotrauka,Aprasymas,Kaina")] Preke preke)
        {
            if (id != preke.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preke);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrekeExists(preke.Id))
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
            return View(preke);
        }

        // GET: Prekes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preke = await _context.Prekes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preke == null)
            {
                return NotFound();
            }

            return View(preke);
        }

        // POST: Prekes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preke = await _context.Prekes.FindAsync(id);
            _context.Prekes.Remove(preke);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrekeExists(int id)
        {
            return _context.Prekes.Any(e => e.Id == id);
        }
    }
}
