using dz3.Models;
using Microsoft.AspNetCore.Mvc;

namespace dz3.Controllers {
	public class HomeController : Controller {
		public ViewResult Index() {
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour < 12 ? "Доброго ранку" : "Добрий день";
			return View();
		}
		[HttpGet]
		public ViewResult RsvpForm() {
			return View();
		}
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest) {
			if (ModelState.IsValid)
	            return View("Thanks", guest);
			else
				return View();
        }
    }
}
