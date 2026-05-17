using Microsoft.AspNetCore.Mvc;

namespace SchoolManager.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
