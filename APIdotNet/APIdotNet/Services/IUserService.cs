using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIdotNet.Models;

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
