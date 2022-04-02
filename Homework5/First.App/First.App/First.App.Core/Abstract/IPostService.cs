using First.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.App.Business.Abstract
{
    public interface IPostService
    {
        void AddPost(Post post);
        void AddPosts(List<Post> posts);
    }
}
