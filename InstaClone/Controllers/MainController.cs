using Microsoft.AspNetCore.Mvc;

namespace InstaClone.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
