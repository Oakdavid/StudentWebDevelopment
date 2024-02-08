using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Contract.Service;
using WebDevelopment.Dtos;
using WebDevelopment.Implementation.Service;

namespace WebDevelopment.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            return View(courses);
        }
        public IActionResult GetAll()
        {
            var courses = _courseService.GetAllCourses();
            return View(courses);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCourseRequestModel model)
        {
            var course = _courseService.Add(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
