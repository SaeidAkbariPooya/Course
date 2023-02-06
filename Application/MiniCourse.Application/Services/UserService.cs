using MiniCourse.Application.Interfaces;
using MiniCourse.Application.Security;
using MiniCourse.Application.ViewModels.Account;
using MiniCourse.Domain.Interfaces;
using MiniCourse.Domain.Models;

namespace MiniCourse.Application.Services
{
    public class UserService:IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public CheckUser CheckUser(string username, string email)
        {
            bool userNameValid = _userRepository.IsExistUserName(username);
            bool emailValid = _userRepository.IsExistEmail(email.Trim().ToLower());

            if (userNameValid && emailValid)
                return ViewModels.Account.CheckUser.UserNameAndEmailNotValid;
            else if (emailValid)
                return ViewModels.Account.CheckUser.EmailNotValid;
            else if (userNameValid)
                return ViewModels.Account.CheckUser.UserNameNotValid;

            return ViewModels.Account.CheckUser.OK;
        }

        public int RegisterUser(User user)
        {
           _userRepository.AddUser(user);
            _userRepository.Save();
            return user.UserId;
        }

        public bool IsExistUser(string email, string password)
        {
            return _userRepository.IsExistUser(email.Trim().ToLower(), PasswordHelper.EncodePasswordMd5(password));
        }
    }
}
