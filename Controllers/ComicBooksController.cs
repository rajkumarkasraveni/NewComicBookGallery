 using Microsoft.AspNetCore.Mvc;

namespace NewComicGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
