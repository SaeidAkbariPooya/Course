using MiniCourse.Application.ViewModels.Account;
using MiniCourse.Domain.Models;

namespace MiniCourse.Application.Interfaces
{
   public interface IUserService
   {
       CheckUser CheckUser(string username, string email);
       int RegisterUser(User user);
       bool IsExistUser(string email, string password);
   }
}
