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
    public class LeaveController : Controller
    {
        private readonly ICONEXTContext _context;

        public LeaveController(ICONEXTContext context)
        {
            _context = context;
        }

        // GET: Leave
        public async Task<IActionResult> Index()
        {
            return View(await _context.Leave.ToListAsync());
        }

        // GET: Leave/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Leave = await _context.Leave
                .FirstOrDefaultAsync(m => m.LID == id);
            if (Leave == null)
            {
                return NotFound();
            }

            return View(Leave);
        }

        // GET: Leave/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Leave/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LID,StartDate,EndDate,note,Days")] Leave Leave)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Leave);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Leave);
        }

        // GET: Leave/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Leave = await _context.Leave.FindAsync(id);
            if (Leave == null)
            {
                return NotFound();
            }
            return View(Leave);
        }

        // POST: Leave/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LID,StartDate,EndDate,note,Days")] Leave Leave)
        {
            if (id != Leave.LID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Leave);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveExists(Leave.LID))
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
            return View(Leave);
        }

        // GET: Leave/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Leave = await _context.Leave
                .FirstOrDefaultAsync(m => m.LID == id);
            if (Leave == null)
            {
                return NotFound();
            }

            return View(Leave);
        }

        // POST: Leave/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Leave = await _context.Leave.FindAsync(id);
            _context.Leave.Remove(Leave);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveExists(int id)
        {
            return _context.Leave.Any(e => e.LID == id);
        }
    }
}
