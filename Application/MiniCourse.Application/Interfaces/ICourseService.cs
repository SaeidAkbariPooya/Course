using MiniCourse.Application.ViewModels;
using MiniCourse.Domain.Models;

namespace MiniCourse.Application.Interfaces
{
   public interface ICourseService
   {
       CourseViewModel GetCourses();
       Course GetCourseById(int courseId);
   }
}
