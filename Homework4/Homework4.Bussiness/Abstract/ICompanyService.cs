using Homeworkfour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Bussiness.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAllCompany();
        void AddCompany(Company company);
        void DeleteCompany(Company company);
        void UpdateCompany(Company company);
    }
}
