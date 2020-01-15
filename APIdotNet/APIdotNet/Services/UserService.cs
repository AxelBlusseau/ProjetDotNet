using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIdotNet.Models;

namespace APIdotNet.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _user;

        public UserService()
        {
            _user = new List<User>();
        }
        public User AddUser(User userToAdd)
        {
            _user.Add(userToAdd);
            return userToAdd;
        }

        public List<User> DeleteUser(int id)
        {
            User userToRemove = new User();
            List<User> users = GetUsers();
            foreach(User item in users)
            {
                if(item.Id == id)
                {
                    userToRemove = item;
                }
            }
            users.Remove(userToRemove);
            return users;
        }

        public List<User> GetUsers()
        {
            return _user;
        }

        public User UpdateUser(User user)
        {
            int index = -1;
            User userToUpdate = new User();
            List<User> users = GetUsers();
            foreach(User item in users)
            {
                if(item.Id == user.Id)
                {
                    index = users.IndexOf(item);
                }
            }
            users[index] = user;
            return user;
        }
    }
}
