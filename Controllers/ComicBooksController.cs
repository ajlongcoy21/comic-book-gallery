using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ComicBookGallery.Models;
using ComicBookGallery.Data;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private readonly ILogger<ComicBooksController> _logger;
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }

        //public ComicBooksController(ILogger<ComicBooksController> logger)
        //{
        //    _logger = logger;
        //}

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
