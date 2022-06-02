﻿using GitHubUserExam.Models.DTO;
using GitHubUserExam.Repository.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace GitHubUserExam.Repository.Implementation
{
    public class UserRepository :IUserRepository
    {

        private string URL = ConfigurationManager.AppSettings["BaseURL"];
        private string param = "/";
        private readonly WebClient _httpClient;

        public UserRepository(WebClient httpClient)
        {
            _httpClient = httpClient;
        }

        public  User Get(string name)
        {
            _httpClient.Headers.Add("User-Agent: Other");
            _httpClient.Headers["Content-type"] = "application/json";
            _httpClient.Encoding = Encoding.UTF8;

            var userJson = _httpClient.DownloadString(URL + param + name);

            var user = JsonConvert.DeserializeObject<User>(userJson);

            return user;

        }


    }
}