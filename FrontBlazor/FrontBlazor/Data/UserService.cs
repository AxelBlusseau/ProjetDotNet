using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;
using System.Net.Http.Headers;


namespace FrontBlazor.Data
{
    public class UserService
    {

        public List<User> Users { get; set; }

        public UserService()
        {
            Users = new List<User>();
        }
        public async Task<List<User>> GetUsers()
        {
            var _client = new HttpClient();

            Users = await _client.GetJsonAsync<List<User>>("http://localhost:52349/api/Users");
            return await Task.FromResult(Users);
        }

        public async Task<User> AddUser(User user)
        {
            var _client = new HttpClient();
            user.Password = sha256(user.Password);
            user = await _client.PostJsonAsync<User>("http://localhost:52349/api/Users", user);
            return await Task.FromResult(user);
        }
        public async Task<User> CheckUser(User user)
        {
            var _client = new HttpClient();
            user.Password = sha256(user.Password);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", user.Mail + ":" + user.Password);
            user = await _client.GetJsonAsync<User>("http://localhost:52349/api/login");
            return await Task.FromResult(user);
        }

        static string sha256(string pwd)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
