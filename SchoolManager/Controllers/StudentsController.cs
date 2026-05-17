using Microsoft.AspNetCore.Mvc;
using SchoolManager.Services;

namespace SchoolManager.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsService _studentsService;
        public StudentsController (StudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        public IActionResult Index()
        {
            var list = _studentsService.FindAll();
            return View(list);
        }

    }
}
