 using Microsoft.AspNetCore.Mvc;

namespace NewComicGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek==DayOfWeek.Thursday)
            {
                return Redirect("/");
            }
            return Content("\"Hello from comicbooks controller!");
            
        }
       
    }
}
