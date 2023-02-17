using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppSklepZoologiczny.Data;
using AppSklepZoologiczny.Models;

namespace AppSklepZoologiczny.Controllers
{
    public class DeliveriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeliveriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Deliveries
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Deliveriess.Include(d => d.Order);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        public async Task<IActionResult> Index(string SearchString)
        {
            var applicationDbContext = _context.Deliveriess.Include(d => d.Order);
            //return View(await applicationDbContext.ToListAsync());
            ViewData["CurrentFilter"] = SearchString;
            var items = from b in applicationDbContext
                        select b;
            if (!String.IsNullOrEmpty(SearchString))
            {
                items = items.Where(x => x.OrderId.ToString().Contains(SearchString));
            }
            return View(items);
        }

        // GET: Deliveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Deliveriess == null)
            {
                return NotFound();
            }

            var deliveries = await _context.Deliveriess
                .Include(d => d.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveries == null)
            {
                return NotFound();
            }

            return View(deliveries);
        }

        // GET: Deliveries/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id");
            return View();
        }

        // POST: Deliveries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderId,DateTimeDeliveries,IsDelivery")] Deliveries deliveries)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(deliveries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id", deliveries.OrderId);
            return View(deliveries);
        }

        // GET: Deliveries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Deliveriess == null)
            {
                return NotFound();
            }

            var deliveries = await _context.Deliveriess.FindAsync(id);
            if (deliveries == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id", deliveries.OrderId);
            return View(deliveries);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderId,DateTimeDeliveries,IsDelivery")] Deliveries deliveries)
        {
            if (id != deliveries.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(deliveries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveriesExists(deliveries.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id", deliveries.OrderId);
            return View(deliveries);
        }

        // GET: Deliveries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Deliveriess == null)
            {
                return NotFound();
            }

            var deliveries = await _context.Deliveriess
                .Include(d => d.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveries == null)
            {
                return NotFound();
            }

            return View(deliveries);
        }

        // POST: Deliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Deliveriess == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Deliveriess'  is null.");
            }
            var deliveries = await _context.Deliveriess.FindAsync(id);
            if (deliveries != null)
            {
                _context.Deliveriess.Remove(deliveries);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveriesExists(int id)
        {
          return _context.Deliveriess.Any(e => e.Id == id);
        }
    }
}
