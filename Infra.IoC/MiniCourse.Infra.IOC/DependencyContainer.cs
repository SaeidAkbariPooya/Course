using MiniCourse.Domain.Interfaces;
using MiniCourse.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using MiniCourse.Application.Services;
using MiniCourse.Application.Interfaces;

namespace MiniCourse.Infra.IOC
{
   public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<ICourseService, CourseService>();

            //Infra Data Layer
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<ICourseRepository, CourseReository>();
        }
    }
}
