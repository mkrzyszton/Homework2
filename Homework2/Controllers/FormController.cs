using Homework2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Input()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Input(FormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Output", model);
            }
            return View(model);
        }
    }
}
