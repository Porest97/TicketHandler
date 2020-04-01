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
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ticket.Include(t => t.Incident).Include(t => t.WL1).Include(t => t.WL2).Include(t => t.WL3);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .Include(t => t.Incident)
                .Include(t => t.WL1)
                .Include(t => t.WL2)
                .Include(t => t.WL3)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id");
            ViewData["WorkLogId"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id");
            ViewData["WorkLogId1"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id");
            ViewData["WorkLogId2"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id");
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TicketNumber,IncidentId,WorkLogId,WorkLogId1,WorkLogId2")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id", ticket.IncidentId);
            ViewData["WorkLogId"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId);
            ViewData["WorkLogId1"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId1);
            ViewData["WorkLogId2"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId2);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id", ticket.IncidentId);
            ViewData["WorkLogId"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId);
            ViewData["WorkLogId1"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId1);
            ViewData["WorkLogId2"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId2);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TicketNumber,IncidentId,WorkLogId,WorkLogId1,WorkLogId2")] Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.Id))
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
            ViewData["IncidentId"] = new SelectList(_context.Incident, "Id", "Id", ticket.IncidentId);
            ViewData["WorkLogId"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId);
            ViewData["WorkLogId1"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId1);
            ViewData["WorkLogId2"] = new SelectList(_context.Set<WorkLog>(), "Id", "Id", ticket.WorkLogId2);
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .Include(t => t.Incident)
                .Include(t => t.WL1)
                .Include(t => t.WL2)
                .Include(t => t.WL3)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Ticket.FindAsync(id);
            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.Id == id);
        }
    }
}
