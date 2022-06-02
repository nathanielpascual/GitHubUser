using GitHubUserExam.Models.DTO;
using GitHubUserExam.Repository.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace GitHubUserExam.Repository.Implementation
{
    public class UserDetailRepository : IUserDetailRepository
    {

        private string URL = ConfigurationManager.AppSettings["BaseURL"];
        private const string param = "/";
        private const string starred = "starred";
        private readonly WebClient _httpClient;
        public UserDetailRepository(WebClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<UserDetails> Get(string name)
        {
            _httpClient.Headers.Add("User-Agent: Other");
            _httpClient.Headers["Content-type"] = "application/json";
            _httpClient.Encoding = Encoding.UTF8;

            var userJson = _httpClient.DownloadString(URL + param + name+param + starred);

            var user = JsonConvert.DeserializeObject<List<UserDetails>>(userJson);

            return user.OrderByDescending(x => x.stargazers_count).Take(5);
        }
    }
}