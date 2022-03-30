using Homeworkfour.Bussiness.Abstract;
using Homeworkfour.DataAccess.EntityFramework.Repository.Abstracts;
using Homeworkfour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Bussiness.Concretes
{ 
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;
        private readonly IUnitOfWork unitOfWork;
        public UserService(IRepository<User> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        

        public void AddUser(User user)
        {
            repository.Add(user);
            unitOfWork.Commit();
        }

        public void DeleteUser(User user)
        {
            repository.Delete(user);
            unitOfWork.Commit();
        }



       

        public void UpdateUser(User user)
        {
            repository.Update(user);
            unitOfWork.Commit();
        }

        List<User> IUserService.GetAllUser()
        {
            return repository.Get().ToList();
        }
    }
}
