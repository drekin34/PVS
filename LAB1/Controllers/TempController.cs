using Microsoft.AspNetCore.Mvc;

namespace LAB1.Controllers
{
    public class TempController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
		public IActionResult aboutus()
		{
			return View();
		}
	}
}
