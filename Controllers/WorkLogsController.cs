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
    public class WorkLogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkLogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WorkLogs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.WorkLog.Include(w => w.Incident).Include(w => w.WorkLogStatus);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WorkLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workLog = await _context.WorkLog
                .Include(w => w.Incident)
                .Include(w => w.WorkLogStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workLog == null)
            {
                return NotFound();
            }

            return View(workLog);
        }

        // GET: WorkLogs/Create
        public IActionResult Create()
        {
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id");
            ViewData["WorkLogStatusId"] = new SelectList(_context.Set<WorkLogStatus>(), "Id", "Id");
            return View();
        }

        // POST: WorkLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WLNumber,Type,State,DateTimeFrom,DateTimeTo,BusUnit,IncidentId,Subject,FEEntersSite,FEEExitsSite,TotalHours,WorkLogStatusId")] WorkLog workLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id", workLog.IncidentId);
            ViewData["WorkLogStatusId"] = new SelectList(_context.Set<WorkLogStatus>(), "Id", "Id", workLog.WorkLogStatusId);
            return View(workLog);
        }

        // GET: WorkLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workLog = await _context.WorkLog.FindAsync(id);
            if (workLog == null)
            {
                return NotFound();
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id", workLog.IncidentId);
            ViewData["WorkLogStatusId"] = new SelectList(_context.Set<WorkLogStatus>(), "Id", "Id", workLog.WorkLogStatusId);
            return View(workLog);
        }

        // POST: WorkLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WLNumber,Type,State,DateTimeFrom,DateTimeTo,BusUnit,IncidentId,Subject,FEEntersSite,FEEExitsSite,TotalHours,WorkLogStatusId")] WorkLog workLog)
        {
            if (id != workLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkLogExists(workLog.Id))
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
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id", workLog.IncidentId);
            ViewData["WorkLogStatusId"] = new SelectList(_context.Set<WorkLogStatus>(), "Id", "Id", workLog.WorkLogStatusId);
            return View(workLog);
        }

        // GET: WorkLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workLog = await _context.WorkLog
                .Include(w => w.Incident)
                .Include(w => w.WorkLogStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workLog == null)
            {
                return NotFound();
            }

            return View(workLog);
        }

        // POST: WorkLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workLog = await _context.WorkLog.FindAsync(id);
            _context.WorkLog.Remove(workLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkLogExists(int id)
        {
            return _context.WorkLog.Any(e => e.Id == id);
        }
    }
}
