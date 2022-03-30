using Homeworkfour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Bussiness.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUser();
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }
}
