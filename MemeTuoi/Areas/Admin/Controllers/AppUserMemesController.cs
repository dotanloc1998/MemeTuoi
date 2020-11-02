using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MemeTuoi.Data;
using MemeTuoi.Interface;
using Microsoft.AspNetCore.Authorization;

namespace MemeTuoi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AppUserMemesController : Controller
    {
        private readonly IUserMeme _context;

        public AppUserMemesController(IUserMeme context)
        {
            _context = context;
        }

        // GET: Admin/AppUserMemes
        public IActionResult Index(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var infos = _context.GetAllAppUserMeme();
            ViewBag.TotalUpvotes = infos.Count();
            if (!String.IsNullOrEmpty(searchString))
            {
                int value;
                if (int.TryParse(searchString, out value))
                {
                    infos = infos.Where(i => i.MemeId == int.Parse(searchString));
                }
                else
                {
                    infos = infos.Where(i => i.UserId.Contains(searchString));
                }
            }
            int pageSize = 5;
            return View(PaginatedList<AppUserMeme>.CreateAsync(infos, pageNumber ?? 1, pageSize));
        }

        // GET: Admin/AppUserMemes/Details/5
        public IActionResult Details(int id)
        {

            var appUserMeme = _context.GetByUserMemeId(id);
            if (appUserMeme == null)
            {
                return NotFound();
            }

            return View(appUserMeme);
        }

        // GET: Admin/AppUserMemes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AppUserMemes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("AppUserMemeId,MemeId,UserId")] AppUserMeme appUserMeme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appUserMeme);
                return RedirectToAction(nameof(Index));
            }
            
            return View(appUserMeme);
        }

        // GET: Admin/AppUserMemes/Edit/5
        public IActionResult Edit(int id)
        {

            var appUserMeme = _context.GetByUserMemeId(id);
            if (appUserMeme == null)
            {
                return NotFound();
            }
            return View(appUserMeme);
        }

        // POST: Admin/AppUserMemes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("AppUserMemeId,MemeId,UserId")] AppUserMeme appUserMeme)
        {
          
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appUserMeme);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppUserMemeExists(appUserMeme.AppUserMemeId))
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
            return View(appUserMeme);
        }

        // GET: Admin/AppUserMemes/Delete/5
        public IActionResult Delete(int id)
        {
            var appUserMeme = _context.GetByUserMemeId(id);
            if (appUserMeme == null)
            {
                return NotFound();
            }
            return View(appUserMeme);
        }

        // POST: Admin/AppUserMemes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var appUserMeme = _context.GetByUserMemeId(id);
            _context.Delete(appUserMeme);
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserMemeExists(int id)
        {
            var userMeme = _context.GetByUserMemeId(id);
            if (userMeme == null)
            {
                return false;
            }

            return true;
        }
    }
}
