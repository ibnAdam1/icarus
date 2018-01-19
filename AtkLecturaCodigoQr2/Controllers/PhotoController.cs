using Microsoft.AspNetCore.Mvc;

namespace AtkLecturaCodigoQr2.Controllers
{
    public class PhotoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string imageName)
        {
            ViewBag.pic = "http://localhost:55694/Images/" + imageName;
            return View();
        }
    }
}