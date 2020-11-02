using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using MemeTuoi.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MemeTuoi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {

        private readonly IUser _context;
        public HomeController(IUser context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewUser(string searchString, string currentFilter, int? pageNumber)
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
            var users = _context.GetAllUser();
            ViewBag.TotalUser = users.Count();
            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Trim();
                List<AppUser> userFound = new List<AppUser>();
                foreach (var user in users)
                {
                    string userName = user.UserName;
                    string phoneNum = user.PhoneNumber;
                    if (phoneNum != null)
                    {
                        if (userName.Contains(searchString) || phoneNum.Contains(searchString) || user.Id.Contains(searchString))
                        {
                            userFound.Add(user);
                        }
                    }
                    else
                    {
                        if (userName.Contains(searchString) || user.Id.Contains(searchString))
                        {
                            userFound.Add(user);
                        }
                    }
                }
                users = userFound;
            }
            int pageSize = 5;
            return View(PaginatedList<AppUser>.CreateAsync(users, pageNumber ?? 1, pageSize));
        }
    }
}