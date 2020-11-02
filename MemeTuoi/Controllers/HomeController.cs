using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Interface;
using Microsoft.AspNetCore.Mvc;
using MemeTuoi.Models;

namespace MemeTuoi.Controllers
{
    public class HomeController : Controller
    {
        private ITheLoai theLoaiService;

        public HomeController(ITheLoai theLoaiService)
        {
            this.theLoaiService = theLoaiService;
        }

        public IActionResult Index()
        {
            return View(theLoaiService.GetAllTheLoais());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
