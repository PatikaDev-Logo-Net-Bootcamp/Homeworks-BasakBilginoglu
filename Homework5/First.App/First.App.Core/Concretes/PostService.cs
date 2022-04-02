using First.App.Business.Abstract;
using First.App.DataAccess.EntityFramework.Repository.Abstracts;
using First.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.App.Business.Concretes
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> repository;
        private readonly IUnitOfWork unitOfWork;

        public PostService(IRepository<Post> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void AddPost(Post post)
        {
            repository.Add(post);
            unitOfWork.Commit();
        }
        public void AddPosts(List<Post> posts)
        {
            foreach (var post in posts)
            {
                repository.Add(post);
            }
            unitOfWork.Commit();
        }
    }
}
