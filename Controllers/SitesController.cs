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
    public class SitesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SitesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sites
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Site.Include(s => s.Company).Include(s => s.Contact1).Include(s => s.Contact2).Include(s => s.SiteRole).Include(s => s.SiteType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var site = await _context.Site
                .Include(s => s.Company)
                .Include(s => s.Contact1)
                .Include(s => s.Contact2)
                .Include(s => s.SiteRole)
                .Include(s => s.SiteType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (site == null)
            {
                return NotFound();
            }

            return View(site);
        }

        // GET: Sites/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Id");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["SiteRoleId"] = new SelectList(_context.Set<SiteRole>(), "Id", "Id");
            ViewData["SiteTypeId"] = new SelectList(_context.Set<SiteType>(), "Id", "Id");
            return View();
        }

        // POST: Sites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SiteNumber,SiteName,StreetAddress,ZipCode,City,Country,NumberOfFloors,SiteNotes,SiteRoleId,SiteTypeId,PersonId,PersonId1,CompanyId")] Site site)
        {
            if (ModelState.IsValid)
            {
                _context.Add(site);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Id", site.CompanyId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", site.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", site.PersonId1);
            ViewData["SiteRoleId"] = new SelectList(_context.Set<SiteRole>(), "Id", "Id", site.SiteRoleId);
            ViewData["SiteTypeId"] = new SelectList(_context.Set<SiteType>(), "Id", "Id", site.SiteTypeId);
            return View(site);
        }

        // GET: Sites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var site = await _context.Site.FindAsync(id);
            if (site == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Id", site.CompanyId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", site.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", site.PersonId1);
            ViewData["SiteRoleId"] = new SelectList(_context.Set<SiteRole>(), "Id", "Id", site.SiteRoleId);
            ViewData["SiteTypeId"] = new SelectList(_context.Set<SiteType>(), "Id", "Id", site.SiteTypeId);
            return View(site);
        }

        // POST: Sites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SiteNumber,SiteName,StreetAddress,ZipCode,City,Country,NumberOfFloors,SiteNotes,SiteRoleId,SiteTypeId,PersonId,PersonId1,CompanyId")] Site site)
        {
            if (id != site.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(site);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiteExists(site.Id))
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
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Id", site.CompanyId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", site.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", site.PersonId1);
            ViewData["SiteRoleId"] = new SelectList(_context.Set<SiteRole>(), "Id", "Id", site.SiteRoleId);
            ViewData["SiteTypeId"] = new SelectList(_context.Set<SiteType>(), "Id", "Id", site.SiteTypeId);
            return View(site);
        }

        // GET: Sites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var site = await _context.Site
                .Include(s => s.Company)
                .Include(s => s.Contact1)
                .Include(s => s.Contact2)
                .Include(s => s.SiteRole)
                .Include(s => s.SiteType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (site == null)
            {
                return NotFound();
            }

            return View(site);
        }

        // POST: Sites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var site = await _context.Site.FindAsync(id);
            _context.Site.Remove(site);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiteExists(int id)
        {
            return _context.Site.Any(e => e.Id == id);
        }
    }
}
