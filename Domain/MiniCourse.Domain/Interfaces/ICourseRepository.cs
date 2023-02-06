using MiniCourse.Domain.Models;

namespace MiniCourse.Domain.Interfaces
{
   public interface ICourseRepository
   {
       IQueryable<Course> GetCourses();
       Course GetCourseById(int courseId);
   }
}
