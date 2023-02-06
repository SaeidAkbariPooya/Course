using MiniCourse.Domain.Interfaces;
using MiniCourse.Domain.Models;
using MiniCourse.Infra.Data.Context;

namespace MiniCourse.Infra.Data.Repository
{
   public class UserRepository:IUserRepository
   {
       private MiniCourseDBContext _ctx;

       public UserRepository(MiniCourseDBContext ctx)
       {
           _ctx = ctx;
       }

       public bool IsExistUser(string email, string password)
       {
           return _ctx.Users.Any(u => u.Email == email && u.Password == password);
       }

       public void AddUser(User user)
        {
            _ctx.Add(user);
        }

        public bool IsExistUserName(string userName)
        {
            return _ctx.Users.Any(u => u.UserName == userName);
        }

        public bool IsExistEmail(string email)
        {
            return _ctx.Users.Any(u => u.Email == email);
        }

       public void Save()
       {
           _ctx.SaveChanges();
       }
   }
}
