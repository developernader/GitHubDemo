using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubDemo.Controllers
{
    public class GitHubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GitHubView()
        {
            return View();
        }

        public IActionResult HistoryView()
        {
            return View();
        }

    }
}
