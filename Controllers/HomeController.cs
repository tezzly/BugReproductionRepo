using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testapp.Models;

namespace testapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetTest()
        {
            return View("WithIndexes");
        }

        public IActionResult GetTest2()
        {
            return View("WithoutIndexes");
        }

        public IActionResult WorkingFine()
        {
            return View("WorkingFine");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WithIndexes(InputModel input, OtherInputModel[] otherinput)
        {
			throw new NotImplementedException();
        }  

		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WithoutIndexes(InputModel input, OtherInputModel[] otherinput)
        {
			throw new NotImplementedException();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WorkingFine(InputModel input, OtherInputModel otherinput)
        {
			throw new NotImplementedException();
        }
    }
}
