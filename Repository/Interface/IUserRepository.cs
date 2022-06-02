using GitHubUserExam.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubUserExam.Repository.Interface
{
	public interface IUserRepository
	{
		User Get(string name);
	}
}
