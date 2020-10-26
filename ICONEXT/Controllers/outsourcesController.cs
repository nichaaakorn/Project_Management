using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ICONEXT.Data;
using ICONEXT.Models;

namespace ICONEXT.Controllers
{
    public class outsourcesController : Controller
    {
        private readonly ICONEXTContext _context;

        public outsourcesController(ICONEXTContext context)
        {
            _context = context;
        }

        // GET: outsources
        public async Task<IActionResult> Index()
        {
            return View(await _context.outsource.ToListAsync());
        }

        // GET: outsources/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outsource = await _context.outsource
                .FirstOrDefaultAsync(m => m.ID == id);
            if (outsource == null)
            {
                return NotFound();
            }

            return View(outsource);
        }

        // GET: outsources/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: outsources/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Name,Surname,Nickname,Position,StartDate,EndDate,Tel,Email,Active")] outsource outsource)
        {
            if (ModelState.IsValid)
            {
                _context.Add(outsource);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(outsource);
        }

        // GET: outsources/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outsource = await _context.outsource.FindAsync(id);
            if (outsource == null)
            {
                return NotFound();
            }
            return View(outsource);
        }

        // POST: outsources/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Title,Name,Surname,Nickname,Position,StartDate,EndDate,Tel,Email,Active")] outsource outsource)
        {
            if (id != outsource.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outsource);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!outsourceExists(outsource.ID))
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
            return View(outsource);
        }

        // GET: outsources/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outsource = await _context.outsource
                .FirstOrDefaultAsync(m => m.ID == id);
            if (outsource == null)
            {
                return NotFound();
            }

            return View(outsource);
        }

        // POST: outsources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var outsource = await _context.outsource.FindAsync(id);
            _context.outsource.Remove(outsource);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool outsourceExists(string id)
        {
            return _context.outsource.Any(e => e.ID == id);
        }
    }
}
