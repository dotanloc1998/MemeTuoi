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
    [Authorize(Roles = "Admin")]
    public class MemesController : Controller
    {

        private readonly IMeme _context;
        private readonly ITheLoai theLoaiService;
        public MemesController(IMeme context, ITheLoai theLoaiService)
        {
            _context = context;
            this.theLoaiService = theLoaiService;
        }

        // GET: Admin/Memes
        public IActionResult Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["CaptionSortParm"] = sortOrder == "Cap" ? "cap_desc" : "Cap";
            ViewData["CatSortParm"] = sortOrder == "Cat" ? "cat_desc" : "Cat";
            ViewData["LikeSortParm"] = sortOrder == "Like" ? "like_desc" : "Like";
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var memes = _context.GetAllMeme();
            ViewBag.TotalMemes = memes.Count();
            if (!String.IsNullOrEmpty(searchString))
            {
                int soTruyenVao;
                if (int.TryParse(searchString,out soTruyenVao))
                {
                    memes = memes.Where(m => m.MemeCategory == soTruyenVao);
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
                case "like_desc":
                    memes = memes.OrderByDescending(s => s.MemeUpvotes);
                    break;
                case "Like":
                    memes = memes.OrderBy(s => s.MemeUpvotes);
                    break;
                default:
                    memes = memes.OrderBy(s => s.MemeID);
                    break;
            }
            int pageSize = 5;
            return View(PaginatedList<Meme>.CreateAsync(memes, pageNumber ?? 1, pageSize));
        }

        // GET: Admin/Memes/Details/5
        public IActionResult Details(int id)
        {

            var meme = _context.GetById(id);
            if (meme == null)
            {
                return NotFound();
            }

            return View(meme);
        }

        // GET: Admin/Memes/Create
        public IActionResult Create()
        {
            Meme moi = new Meme();
            ViewBag.DanhSachTheLoai = theLoaiService.GetAllTheLoais();
            return View(moi);
        }

        // POST: Admin/Memes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MemeID,MemeName,MemeImgUrl,MemeCategory,MemeUpvotes")] Meme meme)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                meme.Uploader = userId;
                if (meme.MemeImgUrl.Contains("youtube"))
                {
                    for (int i = 1; i < meme.MemeImgUrl.Length; i++)
                    {
                        if (meme.MemeImgUrl[i] == '=')
                        {
                            meme.MemeImgUrl = "https://www.youtube.com/embed/" + meme.MemeImgUrl.Substring(i + 1);
                            break;
                        }
                    }
                }
                _context.Add(meme);
                return RedirectToAction(nameof(Index));
            }
            return View(meme);
        }

        // GET: Admin/Memes/Edit/5
        public IActionResult Edit(int id)
        {
            ViewBag.DanhSachTheLoai = theLoaiService.GetAllTheLoais();
            var meme = _context.GetById(id);
            return View(meme);
        }

        // POST: Admin/Memes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("MemeID,MemeName,MemeImgUrl,MemeCategory,MemeUpvotes")] Meme meme)
        {
            if (id != meme.MemeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meme);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemeExists(meme.MemeID))
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
            return View(meme);
        }

        // GET: Admin/Memes/Delete/5
        public IActionResult Delete(int id)
        {
            var meme = _context.GetById(id);
            if (meme == null)
            {
                return NotFound();
            }

            return View(meme);
        }

        // POST: Admin/Memes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var meme = _context.GetById(id);
            _context.Delete(meme);
            return RedirectToAction(nameof(Index));
        }

        private bool MemeExists(int id)
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
