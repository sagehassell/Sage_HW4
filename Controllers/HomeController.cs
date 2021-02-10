using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sage_HW4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sage_HW4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> top5list = new List<string>();

            foreach(Top5List top in Top5List.GetTop5List())
            {
                //Fills fav dish null values with a string 
                string? favdish = top.FavDish ?? "It's all tasty!";

                //builds output
                top5list.Add("#" + top.RestRanking + " " + top.RestName + "<br> Favortie Dish: " + favdish + "<br> Address: " + top.RestAddress + "<br> Phone Number: " + top.RestPhone + "<br> Website: " +  top.RestWebsite );
            }

            return View(top5list);
        }

        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestions(Suggestion suggestion)
        {
            //Determines if we should add the new suggestion
            if (ModelState.IsValid)
            {
                Data.AddSuggestion(suggestion);
                return View("Submitted");
            }
            return View();
        }

        public IActionResult SuggestionsList()
        {
            return View(Data.Suggestions);
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
