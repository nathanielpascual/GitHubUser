
using GitHubUserExam.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUserExam.Services.Interfaces
{
    public interface IUserServices:IDisposable
    {
        UserViewModel GetUser(string name);
    }
}
