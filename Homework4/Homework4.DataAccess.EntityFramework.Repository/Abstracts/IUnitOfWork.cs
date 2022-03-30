using Homework4.DataAccess.EntityFramework;
using System;
namespace Homeworkfour.DataAccess.EntityFramework.Repository.Abstracts
{
    public interface IUnitOfWork : IDisposable
    {
        AppDbContext Context { get; }
        void Commit();

    }
}
