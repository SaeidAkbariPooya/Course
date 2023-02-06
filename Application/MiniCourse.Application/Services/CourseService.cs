using MiniCourse.Application.Interfaces;
using MiniCourse.Application.ViewModels;
using MiniCourse.Domain.Interfaces;
using MiniCourse.Domain.Models;

namespace MiniCourse.Application.Services
{
   public class CourseService : ICourseService
    {
       private ICourseRepository _courseRepository;

       public CourseService(ICourseRepository courseRepository)
       {
           _courseRepository = courseRepository;
       }

        public Course GetCourseById(int courseId)
        {
            Course course = _courseRepository.GetCourseById(courseId);
            return course;
        }

        public CourseViewModel GetCourses()
        {
           return new CourseViewModel()
           {
               Courses = _courseRepository.GetCourses()
           };
        }
    }
}
