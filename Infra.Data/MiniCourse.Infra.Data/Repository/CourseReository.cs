using MiniCourse.Domain.Interfaces;
using MiniCourse.Domain.Models;
using MiniCourse.Infra.Data.Context;

namespace MiniCourse.Infra.Data.Repository
{
   public class CourseReository:ICourseRepository
   {
       private MiniCourseDBContext _ctx;

       public CourseReository(MiniCourseDBContext ctx)
       {
           this._ctx = ctx;
       }
        public IQueryable<Course> GetCourses()
        {
            return _ctx.Courses;
        }

       public Course GetCourseById(int courseId)
       {
           return _ctx.Courses.Find(courseId);
       }
   }
}
