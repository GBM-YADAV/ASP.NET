using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvc_Code_first_practice2.Models;

namespace mvc_Code_first_practice2.Controllers
{
    public class ValidController : Controller
    {
        private readonly AppDbContext _context;

        public ValidController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Valid
        public async Task<IActionResult> Index()
        {
            return View(await _context.Validate.ToListAsync());
        }

        // GET: Valid/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valid = await _context.Validate
                .FirstOrDefaultAsync(m => m.id == id);
            if (valid == null)
            {
                return NotFound();
            }

            return View(valid);
        }

        // GET: Valid/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Valid/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,mail")] Valid valid)
        {
            if (ModelState.IsValid)
            {
                _context.Add(valid);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(valid);
        }

        // GET: Valid/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valid = await _context.Validate.FindAsync(id);
            if (valid == null)
            {
                return NotFound();
            }
            return View(valid);
        }

        // POST: Valid/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,mail")] Valid valid)
        {
            if (id != valid.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(valid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValidExists(valid.id))
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
            return View(valid);
        }

        // GET: Valid/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valid = await _context.Validate
                .FirstOrDefaultAsync(m => m.id == id);
            if (valid == null)
            {
                return NotFound();
            }

            return View(valid);
        }

        // POST: Valid/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var valid = await _context.Validate.FindAsync(id);
            _context.Validate.Remove(valid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ValidExists(int id)
        {
            return _context.Validate.Any(e => e.id == id);
        }
    }
}
