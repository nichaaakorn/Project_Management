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
    public class PhaseProjectsController : Controller
    {
        private readonly ICONEXTContext _context;

        public PhaseProjectsController(ICONEXTContext context)
        {
            _context = context;
        }

        // GET: PhaseProjects
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhaseProject.ToListAsync());
        }

        // GET: PhaseProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phaseProject = await _context.PhaseProject
                .FirstOrDefaultAsync(m => m.PID == id);
            if (phaseProject == null)
            {
                return NotFound();
            }

            return View(phaseProject);
        }

        // GET: PhaseProjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhaseProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PID,Phase,FromDate,EndDate,Usage")] PhaseProject phaseProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phaseProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phaseProject);
        }

        // GET: PhaseProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phaseProject = await _context.PhaseProject.FindAsync(id);
            if (phaseProject == null)
            {
                return NotFound();
            }
            return View(phaseProject);
        }

        // POST: PhaseProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PID,Phase,FromDate,EndDate,Usage")] PhaseProject phaseProject)
        {
            if (id != phaseProject.PID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phaseProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhaseProjectExists(phaseProject.PID))
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
            return View(phaseProject);
        }

        // GET: PhaseProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phaseProject = await _context.PhaseProject
                .FirstOrDefaultAsync(m => m.PID == id);
            if (phaseProject == null)
            {
                return NotFound();
            }

            return View(phaseProject);
        }

        // POST: PhaseProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phaseProject = await _context.PhaseProject.FindAsync(id);
            _context.PhaseProject.Remove(phaseProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhaseProjectExists(int id)
        {
            return _context.PhaseProject.Any(e => e.PID == id);
        }
    }
}
