using GitHubUserExam.Models.DTO;
using System.Collections.Generic;

namespace GitHubUserExam.Repository.Interface
{
	public interface IUserDetailRepository
	{
		IEnumerable<UserDetails> Get(string name);
	}
}
