using Microsoft.AspNetCore.Mvc;
using MiniCourse.Application.Interfaces;
using MiniCourse.Application.ViewModels;
using MiniCourse.Domain.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniCourse.Presentaion.Controllers
{
    //[Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CourseViewModel model =_courseService.GetCourses();
            return View(model);
        }

        //[AllowAnonymous]
        public IActionResult ShowCourse(int id)
        {
            Course course = _courseService.GetCourseById(id);
            if (course == null)
                return NotFound();

            return View(course);
        }
    }
}
