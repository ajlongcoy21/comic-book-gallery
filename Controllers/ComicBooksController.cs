using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private readonly ILogger<ComicBooksController> _logger;

        public ActionResult Detail()
        {
            return View();
        }

        public ComicBooksController(ILogger<ComicBooksController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
