using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using httpoverrides_test.Models;

namespace httpoverrides_test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("header: ");
            foreach (var item in Request.Headers)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            Console.WriteLine("Scheme: " + Request.Scheme);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

        public IActionResult RedirectP()
        {
            return RedirectToActionPermanent("Index");
        }
    }
}
