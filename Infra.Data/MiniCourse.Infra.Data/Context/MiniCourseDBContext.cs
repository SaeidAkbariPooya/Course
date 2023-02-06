using Microsoft.EntityFrameworkCore;
using MiniCourse.Domain.Models;

namespace MiniCourse.Infra.Data.Context
{
    public class MiniCourseDBContext: DbContext
    {

        public MiniCourseDBContext(DbContextOptions<MiniCourseDBContext> options)
        :base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
