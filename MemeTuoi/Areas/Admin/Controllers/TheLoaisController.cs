using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MemeTuoi.Data;
using MemeTuoi.Interface;

namespace MemeTuoi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TheLoaisController : Controller
    {
        private readonly ITheLoai _context;

        public TheLoaisController(ITheLoai context)
        {
            _context = context;
        }

        // GET: Admin/TheLoais
        public IActionResult Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TheLoaiIdSortParm"] = sortOrder == "Id" ? "id_desc" : "Id";
            ViewData["NameSortParm"] = sortOrder == "Name" ? "name_desc" : "Name";
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var theLoais = _context.GetAllTheLoais();
            ViewBag.TotalTheLoais = theLoais.Count();
            if (!String.IsNullOrEmpty(searchString))
            {
                int soNhapVao;
                if (int.TryParse(searchString,out soNhapVao))
                {
                    theLoais = theLoais.Where(m => m.TheLoaiId == int.Parse(searchString));
                }
                else
                {
                    theLoais = theLoais.Where(m => m.TenTheLoai.Contains(searchString));
                }
            }

            switch (sortOrder)
            {
                case "id_desc":
                    theLoais = theLoais.OrderByDescending(s => s.TheLoaiId);
                    break;
                case "Id":
                    theLoais = theLoais.OrderBy(s => s.TheLoaiId);
                    break;
                case "name_desc":
                    theLoais = theLoais.OrderByDescending(s => s.TenTheLoai);
                    break;
                case "Name":
                    theLoais = theLoais.OrderBy(s => s.TenTheLoai);
                    break;
                default:
                    theLoais = theLoais.OrderBy(s => s.TheLoaiId);
                    break;
            }
            int pageSize = 5;
            return View(PaginatedList<TheLoai>.CreateAsync(theLoais, pageNumber ?? 1, pageSize));
        }

        // GET: Admin/TheLoais/Details/5
        public IActionResult Details(int id)
        {

            var theLoai = _context.GetById(id);
            if (theLoai == null)
            {
                return NotFound();
            }

            return View(theLoai);
        }

        // GET: Admin/TheLoais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TheLoais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TheLoaiId,TenTheLoai,AnhTheLoai")] TheLoai theLoai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theLoai);
                return RedirectToAction(nameof(Index));
            }
            return View(theLoai);
        }

        // GET: Admin/TheLoais/Edit/5
        public IActionResult Edit(int id)
        {

            var theLoai = _context.GetById(id);
            if (theLoai == null)
            {
                return NotFound();
            }
            return View(theLoai);
        }

        // POST: Admin/TheLoais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("TheLoaiId,TenTheLoai,AnhTheLoai")] TheLoai theLoai)
        {
            if (id != theLoai.TheLoaiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theLoai);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheLoaiExists(theLoai.TheLoaiId))
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
            return View(theLoai);
        }

        // GET: Admin/TheLoais/Delete/5
        public IActionResult Delete(int id)
        {

            var theLoai = _context.GetById(id);
            if (theLoai == null)
            {
                return NotFound();
            }

            return View(theLoai);
        }

        // POST: Admin/TheLoais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var theLoai = _context.GetById(id);
            _context.Delete(theLoai);
            return RedirectToAction(nameof(Index));
        }

        private bool TheLoaiExists(int id)
        {
            var theLoai = _context.GetById(id);
            if (theLoai == null)
            {
                return false;
            }

            return true;
        }
    }
}
