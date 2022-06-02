
using System.Collections.Generic;

using GitHubUserExam.Models.DTO;
namespace GitHubUserExam.Models.ViewModels
{
    public class UserViewModel
    {
       public User UserProfile { get; set; }

       public List<UserDetails> UserDetails { get; set; }

      public string ErrorMessage { get; set; }
    }
}