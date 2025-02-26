using Microsoft.AspNetCore.Mvc;

namespace session5_6Task.Controllers
{
    public class blogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
