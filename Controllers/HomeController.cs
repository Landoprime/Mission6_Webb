
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging; // Import ILogger
using Mission6_LandonWebb.Models;
using System.Diagnostics;

namespace Mission6_LandonWebb.Controllers
{
    public class HomeController : Controller
    {
        private readonly Mission6Context _context;
        private readonly ILogger<HomeController> _logger;

        // Constructor with dependencies injected
        public HomeController(Mission6Context context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getToKnowJoel()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Movie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Movie", new Movie());
            
        }

        [HttpPost]
        public IActionResult MovieForm(Movie model)
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            if (ModelState.IsValid)
            {
                _context.Movies.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index"); // Redirect to a different action after successful submission
            }
            else
            {
                // Handle validation errors
                return View("Movie", model); // Return to the Movie view with validation errors
            }
        }

        public IActionResult Collection()
        {
            var Movies = _context.Movies
                .Include("Category")
                .ToList();

            return View(Movies);
                
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Movie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Collection");
        }


        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
                
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("Collection");
        }
    }
}

