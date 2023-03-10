using Microsoft.AspNetCore.Mvc;
using Web.Models;
namespace Web.Controllers
{
   public class CarController : Controller
   {
      [HttpGet]
      public IActionResult Index()
      {
         return View();
      }

      [HttpGet]
      public IActionResult Create()
      {
         return View();
      }

      [HttpPost]
      public IActionResult Create(Car model)
      {
         if (ModelState.IsValid)
         {

         }
         return RedirectToAction(nameof(Create));
      }
   }
}
