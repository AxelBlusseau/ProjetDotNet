using APIdotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIdotNet.Services
{
    public interface IUserService
    {
        User AddUser(User userToAdd);
        List<User> GetUsers();
        List<User> DeleteUser(int idUser);
        User UpdateUser(User user);
    }
}
