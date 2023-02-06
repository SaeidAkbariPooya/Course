using MiniCourse.Domain.Models;

namespace MiniCourse.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
