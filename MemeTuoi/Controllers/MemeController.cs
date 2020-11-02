using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using MemeTuoi.Data;
using MemeTuoi.Interface;
using MemeTuoi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MemeTuoi.Controllers
{
    public class MemeController : Controller
    {
        private IMeme memeService;
        private IMemeCanDuyet memeCanDuyetService;
        private IUserMeme userMemeService;
        private ITheLoai theLoaiService;
        public MemeController(IMeme memeService, IUserMeme userMemeService, ITheLoai theLoaiService, IMemeCanDuyet memeCanDuyetService)
        {
            this.memeService = memeService;
            this.userMemeService = userMemeService;
            this.theLoaiService = theLoaiService;
            this.memeCanDuyetService = memeCanDuyetService;
        }

        public IActionResult Index(int id, string searchString, string currentFilter, int? pageNumber)
        {
            ViewBag.DanhSachTheLoai = theLoaiService.GetAllTheLoais();
            ViewBag.TiTle = theLoaiService.GetById(id).TenTheLoai;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var memes = memeService.GetMemeByCategory(id);
            if (!String.IsNullOrEmpty(searchString))
            {
                memes = memes.Where(m =>
                    m.MemeName.Contains(searchString));
            }
            int pageSize = 10;
            return View(PaginatedList<Meme>.CreateAsync(memes, pageNumber ?? 1, pageSize));
        }

        [Authorize]
        public IActionResult UpVote(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            AppUserMeme timThay = userMemeService.GetByUserIdMemeId(userId, id);
            Meme chinhSua = memeService.GetById(id);
            if (timThay != null)
            {
                if (timThay.UporDown == "uv")
                {
                    chinhSua.MemeUpvotes--;
                    memeService.Update(chinhSua);
                    userMemeService.Delete(timThay);
                }
                else
                {
                    chinhSua.MemeUpvotes += 2;
                    memeService.Update(chinhSua);
                    timThay.UporDown = "uv";
                    userMemeService.Update(timThay);
                }
            }
            else
            {
                AppUserMeme lichSuUpVoteMoi = new AppUserMeme();
                lichSuUpVoteMoi.MemeId = id;
                lichSuUpVoteMoi.UserId = userId;
                lichSuUpVoteMoi.UporDown = "uv";
                chinhSua.MemeUpvotes++;
                memeService.Update(chinhSua);
                userMemeService.Add(lichSuUpVoteMoi);
            }
            return RedirectToAction("Index", new { id = chinhSua.MemeCategory });
        }
        [Authorize]
        public IActionResult DownVote(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            AppUserMeme timThay = userMemeService.GetByUserIdMemeId(userId, id);
            Meme chinhSua = memeService.GetById(id);
            if (timThay != null)
            {
                if (timThay.UporDown == "dv")
                {
                    chinhSua.MemeUpvotes++;
                    memeService.Update(chinhSua);
                    userMemeService.Delete(timThay);
                }
                else
                {
                    chinhSua.MemeUpvotes -= 2;
                    memeService.Update(chinhSua);
                    timThay.UporDown = "dv";
                    userMemeService.Update(timThay);
                }
            }
            else
            {
                AppUserMeme lichSuUpVoteMoi = new AppUserMeme();
                lichSuUpVoteMoi.MemeId = id;
                lichSuUpVoteMoi.UserId = userId;
                lichSuUpVoteMoi.UporDown = "dv";
                chinhSua.MemeUpvotes--;
                memeService.Update(chinhSua);
                userMemeService.Add(lichSuUpVoteMoi);
            }
            return RedirectToAction("Index", new { id = chinhSua.MemeCategory });
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewBag.DanhSachTheLoai = theLoaiService.GetAllTheLoais();
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MemeID,MemeName,MemeImgUrl,MemeCategory")] MemeCanDuyet meme)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                meme.Uploader = userId;
                meme.MemeUpvotes = 0;
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
                memeCanDuyetService.Add(meme);
                return RedirectToAction("Index", new { id = meme.MemeCategory });
            }
            return View(meme);
        }

        public IActionResult MemeDetail(int id)
        {
            Meme memeTruyenVao = memeService.GetById(id);
            ViewBag.DanhSachTheLoai = theLoaiService.GetAllTheLoais();
            ViewBag.TiTle = theLoaiService.GetById(memeTruyenVao.MemeCategory).TenTheLoai;
            return View(memeTruyenVao);
        }

        [Authorize]
        public IActionResult UpVoteDetail(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            AppUserMeme timThay = userMemeService.GetByUserIdMemeId(userId, id);
            Meme chinhSua = memeService.GetById(id);
            if (timThay != null)
            {
                if (timThay.UporDown == "uv")
                {
                    chinhSua.MemeUpvotes--;
                    memeService.Update(chinhSua);
                    userMemeService.Delete(timThay);
                }
                else
                {
                    chinhSua.MemeUpvotes += 2;
                    memeService.Update(chinhSua);
                    timThay.UporDown = "uv";
                    userMemeService.Update(timThay);
                }
            }
            else
            {
                AppUserMeme lichSuUpVoteMoi = new AppUserMeme();
                lichSuUpVoteMoi.MemeId = id;
                lichSuUpVoteMoi.UserId = userId;
                lichSuUpVoteMoi.UporDown = "uv";
                chinhSua.MemeUpvotes++;
                memeService.Update(chinhSua);
                userMemeService.Add(lichSuUpVoteMoi);
            }
            return RedirectToAction("MemeDetail", new { id = chinhSua.MemeID });
        }
        [Authorize]
        public IActionResult DownVoteDetail(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            AppUserMeme timThay = userMemeService.GetByUserIdMemeId(userId, id);
            Meme chinhSua = memeService.GetById(id);
            if (timThay != null)
            {
                if (timThay.UporDown == "dv")
                {
                    chinhSua.MemeUpvotes++;
                    memeService.Update(chinhSua);
                    userMemeService.Delete(timThay);
                }
                else
                {
                    chinhSua.MemeUpvotes -= 2;
                    memeService.Update(chinhSua);
                    timThay.UporDown = "dv";
                    userMemeService.Update(timThay);
                }
            }
            else
            {
                AppUserMeme lichSuUpVoteMoi = new AppUserMeme();
                lichSuUpVoteMoi.MemeId = id;
                lichSuUpVoteMoi.UserId = userId;
                lichSuUpVoteMoi.UporDown = "dv";
                chinhSua.MemeUpvotes--;
                memeService.Update(chinhSua);
                userMemeService.Add(lichSuUpVoteMoi);
            }
            return RedirectToAction("MemeDetail", new { id = chinhSua.MemeID });
        }
    }
}