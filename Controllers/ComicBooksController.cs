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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Role = "Script" },
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() {Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() {Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters" }
                }

                
            };

            return View(comicBook);
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
