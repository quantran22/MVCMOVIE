using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Data;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class MatHangController : Controller
    {
        private readonly AplicationDBContext _context;

        public MatHangController(AplicationDBContext context)
        {
            _context = context;
        }

        // GET: MatHang
        public async Task<IActionResult> Index()
        {
            return View(await _context.MatHang.ToListAsync());
        }

        // GET: MatHang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang
                .FirstOrDefaultAsync(m => m.IDMatHang == id);
            if (matHang == null)
            {
                return NotFound();
            }

            return View(matHang);
        }

        // GET: MatHang/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryName");
            return View();
        }

        // POST: MatHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDMatHang,TenMatHang,CategoryID")] MatHang matHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryName", matHang.CategoryID);
            return View(matHang);
        }

        // GET: MatHang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang.FindAsync(id);
            if (matHang == null)
            {
                return NotFound();
            }
            return View(matHang);
        }

        // POST: MatHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDMatHang,TenMatHang,CategoryID")] MatHang matHang)
        {
            if (id != matHang.IDMatHang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatHangExists(matHang.IDMatHang))
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
            return View(matHang);
        }

        // GET: MatHang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang
                .FirstOrDefaultAsync(m => m.IDMatHang == id);
            if (matHang == null)
            {
                return NotFound();
            }

            return View(matHang);
        }

        // POST: MatHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var matHang = await _context.MatHang.FindAsync(id);
            _context.MatHang.Remove(matHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatHangExists(string id)
        {
            return _context.MatHang.Any(e => e.IDMatHang == id);
        }
    }
}
