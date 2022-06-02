using GitHubUserExam.Models;
using GitHubUserExam.Models.DTO;
using GitHubUserExam.Models.ViewModels;
using GitHubUserExam.Repository.Interface;
using GitHubUserExam.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUserExam.Services.Implementation
{
    public class UserServices : IUserServices
    {
        private IUserRepository _repository;
        private IUserDetailRepository _repository1;
        public UserServices(IUserRepository repository,
                            IUserDetailRepository repository1)
        {
            _repository = repository;
            _repository1 = repository1;
        }

        public UserViewModel GetUser(string name)
        {
            var userView = new UserViewModel()
            {
                UserProfile = new User(),
                UserDetails = new List<UserDetails>(),
                ErrorMessage = null
            };

            if (name.Contains("InitialEntry"))
                return userView;

            if (name.Contains(" ") || name == "")
            {
                userView.ErrorMessage = @"You Entered an Invalid character.";
                return userView;
            }
               
            try
            {
                var user = _repository.Get(name);

                if (user.name == null || user.location == null || user.login == null)
                {
                    userView.ErrorMessage = @"The user is invalid.";
                    return userView;
                }

                userView.UserProfile = user;
            }
            catch (Exception ex)
            {
                userView.ErrorMessage = @"The user is invalid.";
                Console.WriteLine(ex.Message);
                return userView;
            }

            try
            {

                var userDetails = _repository1.Get(userView.UserProfile.login.ToString());

                if (userDetails != null && userDetails.Count() > 0)
                    userView.UserDetails = userDetails.ToList();
                else
                {
                    userView.ErrorMessage = @"The user has no valid Repositories.";
                    return userView;
                }
            }
            catch(Exception ex)
            {
                userView.ErrorMessage = @"An Error has occured while processing.";
                Console.WriteLine(ex.Message);
                return userView;
            }

            return userView;
        }

        public void Dispose()
        {
            this._repository = null;
            this._repository1 = null;   
        }

    }
}