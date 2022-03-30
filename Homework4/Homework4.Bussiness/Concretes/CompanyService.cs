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
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> repository;
        private readonly IUnitOfWork unitOfWork;


        public void AddCompany(Company company)
        {
            repository.Add(company);
            unitOfWork.Commit();
        }

        public List<Company> GetAllCompany()
        {
            return repository.Get().ToList();
        }
        public void DeleteCompany(Company company)
        {

            repository.Delete(company);
            unitOfWork.Commit();
        }
        public void UpdateCompany(Company company)
        {

            repository.Update(company);
            unitOfWork.Commit();

        }
    }
}
