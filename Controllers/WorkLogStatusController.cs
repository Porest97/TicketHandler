using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketHandler.Data;
using TicketHandler.Models.DataModels;

namespace TicketHandler.Controllers
{
    public class WorkLogStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkLogStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WorkLogStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.WorkLogStatus.ToListAsync());
        }



        // GET: WorkLogStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workLogStatus = await _context.WorkLogStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workLogStatus == null)
            {
                return NotFound();
            }

            return View(workLogStatus);
        }

        // GET: WorkLogStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WorkLogStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WorkLogStatusName")] WorkLogStatus workLogStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workLogStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workLogStatus);
        }

        // GET: WorkLogStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workLogStatus = await _context.WorkLogStatus.FindAsync(id);
            if (workLogStatus == null)
            {
                return NotFound();
            }
            return View(workLogStatus);
        }

        // POST: WorkLogStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WorkLogStatusName")] WorkLogStatus workLogStatus)
        {
            if (id != workLogStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workLogStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkLogStatusExists(workLogStatus.Id))
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
            return View(workLogStatus);
        }

        // GET: WorkLogStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workLogStatus = await _context.WorkLogStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workLogStatus == null)
            {
                return NotFound();
            }

            return View(workLogStatus);
        }

        // POST: WorkLogStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workLogStatus = await _context.WorkLogStatus.FindAsync(id);
            _context.WorkLogStatus.Remove(workLogStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkLogStatusExists(int id)
        {
            return _context.WorkLogStatus.Any(e => e.Id == id);
        }
    }
}
