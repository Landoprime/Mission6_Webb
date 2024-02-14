//using Microsoft.AspNetCore.Mvc;
//using Mission6_LandonWebb.Models;
//using System.Diagnostics;

//namespace Mission6_LandonWebb.Controllers
//{
//    public class HomeController : Controller
//    {
//        private Mission6Context _context;

//        public HomeController(Mission6Context Temp)
//        {
//            _context = Temp;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult getToKnowJoel()
//        {
//            return View();
//        }

//        public IActionResult Movie()
//        {
//            return View();
//        }

//        [HttpGet]
//        public IActionResult MovieForm() 
//        {
//            return View("Movie");
//        }

//        [HttpPost]
//        public IActionResult MovieForm(Movie response) 
//        {
//            _context.Movies.Add(response); // Add record to database
//            _context.SaveChanges();
//            return View("Confirmation", response);
//        }
//}

using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Movie()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View("Movie");
        }

        [HttpPost]
        public IActionResult MovieForm(Movie model)
        {
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
    }
}

