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
    public class TaskProjectsController : Controller
    {
        private readonly ICONEXTContext _context;

        public TaskProjectsController(ICONEXTContext context)
        {
            _context = context;
        }

        // GET: TaskProjects
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaskProject.ToListAsync());
        }

        // GET: TaskProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskProject = await _context.TaskProject
                .FirstOrDefaultAsync(m => m.TID == id);
            if (taskProject == null)
            {
                return NotFound();
            }

            return View(taskProject);
        }

        // GET: TaskProjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaskProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TID,Tasks")] TaskProject taskProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskProject);
        }

        // GET: TaskProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskProject = await _context.TaskProject.FindAsync(id);
            if (taskProject == null)
            {
                return NotFound();
            }
            return View(taskProject);
        }

        // POST: TaskProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TID,Tasks")] TaskProject taskProject)
        {
            if (id != taskProject.TID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskProjectExists(taskProject.TID))
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
            return View(taskProject);
        }

        // GET: TaskProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskProject = await _context.TaskProject
                .FirstOrDefaultAsync(m => m.TID == id);
            if (taskProject == null)
            {
                return NotFound();
            }

            return View(taskProject);
        }

        // POST: TaskProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskProject = await _context.TaskProject.FindAsync(id);
            _context.TaskProject.Remove(taskProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskProjectExists(int id)
        {
            return _context.TaskProject.Any(e => e.TID == id);
        }
    }
}
