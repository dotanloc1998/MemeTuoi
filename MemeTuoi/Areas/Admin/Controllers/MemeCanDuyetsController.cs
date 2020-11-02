using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MemeTuoi.Data;
using MemeTuoi.Interface;
using MemeTuoi.Models;
using Microsoft.AspNetCore.Authorization;

namespace MemeTuoi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MemeCanDuyetsController : Controller
    {
        private readonly IMemeCanDuyet _context;
        private readonly ITheLoai theLoaiService;
        private readonly IMeme memeService;
        public MemeCanDuyetsController(IMemeCanDuyet context, ITheLoai theLoaiService, IMeme memeService)
        {
            _context = context;
            this.theLoaiService = theLoaiService;
            this.memeService = memeService;
        }

        // GET: Admin/MemeCanDuyets
        public IActionResult Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["CaptionSortParm"] = sortOrder == "Cap" ? "cap_desc" : "Cap";
            ViewData["CatSortParm"] = sortOrder == "Cat" ? "cat_desc" : "Cat";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var memes = _context.GetAllMemeCanDuyet();
            ViewBag.TotalMemes = memes.Count();
            if (!String.IsNullOrEmpty(searchString))
            {
                int soNhapVao;
                if (int.TryParse(searchString, out soNhapVao))
                {
                    memes = memes.Where(m => m.MemeCategory == int.Parse(searchString));
                }
                else
                {
                    memes = memes.Where(m =>
                        m.MemeName.Contains(searchString) ||
                        m.MemeImgUrl.Contains(searchString) || m.Uploader.Contains(searchString));
                }
            }
            switch (sortOrder)
            {
                case "cap_desc":
                    memes = memes.OrderByDescending(s => s.MemeName);
                    break;
                case "Cap":
                    memes = memes.OrderBy(s => s.MemeName);
                    break;
                case "cat_desc":
                    memes = memes.OrderByDescending(s => s.MemeCategory);
                    break;
                case "Cat":
                    memes = memes.OrderBy(s => s.MemeCategory);
                    break;
                default:
                    memes = memes.OrderBy(s => s.MemeCanDuyetID);
                    break;
            }
            int pageSize = 5;
            return View(PaginatedList<MemeCanDuyet>.CreateAsync(memes, pageNumber ?? 1, pageSize));
        }

        // GET: Admin/MemeCanDuyets/Details/5
        public IActionResult Details(int id)
        {

            var memeCanDuyet = _context.GetById(id);
            if (memeCanDuyet == null)
            {
                return NotFound();
            }

            return View(memeCanDuyet);
        }

        // GET: Admin/MemeCanDuyets/Edit/5
        public IActionResult Edit(int id)
        {
            var memeCanDuyet = _context.GetById(id);
            ViewBag.DanhSachTheLoai = theLoaiService.GetAllTheLoais();
            if (memeCanDuyet == null)
            {
                return NotFound();
            }
            return View(memeCanDuyet);
        }

        // POST: Admin/MemeCanDuyets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("MemeCanDuyetID,MemeName,MemeImgUrl,MemeCategory,MemeUpvotes,Uploader")] MemeCanDuyet memeCanDuyet)
        {
            if (id != memeCanDuyet.MemeCanDuyetID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memeCanDuyet);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemeCanDuyetExists(memeCanDuyet.MemeCanDuyetID))
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
            return View(memeCanDuyet);
        }

        // GET: Admin/MemeCanDuyets/Delete/5
        public IActionResult Delete(int id)
        {

            var memeCanDuyet = _context.GetById(id);
            if (memeCanDuyet == null)
            {
                return NotFound();
            }

            return View(memeCanDuyet);
        }

        // POST: Admin/MemeCanDuyets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var memeCanDuyet = _context.GetById(id);
            _context.Delete(memeCanDuyet);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Fresh(int id)
        {

            var memeCanDuyet = _context.GetById(id);
            if (memeCanDuyet == null)
            {
                return NotFound();
            }

            return View(memeCanDuyet);
        }
        [HttpPost, ActionName("Fresh")]
        [ValidateAntiForgeryToken]
        public IActionResult FreshConfirmed(int id)
        {
            var memeCanDuyet = _context.GetById(id);
            Meme moi = new Meme();
            moi.MemeCategory = memeCanDuyet.MemeCategory;
            moi.MemeImgUrl = memeCanDuyet.MemeImgUrl;
            moi.Uploader = memeCanDuyet.Uploader;
            moi.MemeName = memeCanDuyet.MemeName;
            moi.MemeUpvotes = memeCanDuyet.MemeUpvotes;
            _context.Delete(memeCanDuyet);
            memeService.Add(moi);
            return RedirectToAction(nameof(Index));
        }
        private bool MemeCanDuyetExists(int id)
        {
            var meme = _context.GetById(id);
            if (meme == null)
            {
                return false;
            }

            return true;
        }
    }
}
