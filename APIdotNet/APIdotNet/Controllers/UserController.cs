using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIdotNet.Models;
using APIdotNet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIdotNet.Controllers
{
    [Route("users/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _services;

        public UserController(IUserService services)
        {
            _services = services;
        }
        //9:35 de la video

        [HttpPost]
        [Route("AddUser")]
        public ActionResult<User> AddUser(User userToAdd)
        {
            var user = _services.AddUser(userToAdd);
            if(user == null)
            {
                return NotFound();
            }
            Console.WriteLine(_services.GetUsers());
            return user;
        }
        [HttpGet]
        [Route("GetUsers")]
        public ActionResult<List<User>> GetUsers()
        {
            var users = _services.GetUsers();
            if(users.Count == 0)
            {
                return NotFound();
            }
            Console.WriteLine(users);

            return users;

        }
        [HttpDelete]
        [Route("Delete/{Id}")]
        public ActionResult<string> DeleteUser(int Id)
        {
            _services.DeleteUser(Id);
            return "Utilisateur Supprimé";
        }
        [HttpPut]
        [Route("Update/{Id}")]
        public ActionResult<User> UpdateUser(User user)
        {
            User userUpdated = _services.UpdateUser(user);
            return userUpdated;
        }
    }
}