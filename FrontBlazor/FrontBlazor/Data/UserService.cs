using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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
    }
}
