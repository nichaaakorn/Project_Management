using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ICONEXT.Data;
using ICONEXT.Models;
using System.Collections;
using Microsoft.AspNetCore.Builder;

namespace ICONEXT.Controllers
{
    public class projectsController : Controller
    {
        private readonly ICONEXTContext _context;

        public projectsController(ICONEXTContext context)
        {
            _context = context;
        }

        // GET: projects
         public async Task<IActionResult> Index()
        {
          return View(await _context.project.ToListAsync());
        }



        public IActionResult ViewProject()
        {
            return View();
        }



        // GET: projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.project
                .FirstOrDefaultAsync(m => m.ProjID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: projects/Create

        
        public IActionResult Create()
        {
            return View();
        }

        // POST: projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjID,Name,Partner,Customer,StartDate")] project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.project.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

   
        // POST: projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjID,Name,Partner,Customer,StartDate")] project project)
        {
            if (id != project.ProjID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!projectExists(project.ProjID))
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
            return View(project);
        }

        // GET: projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.project
                .FirstOrDefaultAsync(m => m.ProjID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.project.FindAsync(id);
            _context.project.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool projectExists(int id)
        {
            return _context.project.Any(e => e.ProjID == id);
        }
        
           
        }

}
