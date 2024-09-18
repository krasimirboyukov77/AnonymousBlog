using AnonymousBlog.Contracts;
using AnonymousBlog.Data;
using AnonymousBlog.Data.Models;
using AnonymousBlog.Data.ViewDataModels;

namespace AnonymousBlog.Services
{
    public class PostService : IPostService
    {
        public bool AddPost(ViewData_Post post)
        {
            return Database.AddPost(post);
        }

        public bool DeletePost(int id)
        {
            return Database.DeletePost(id);
        }

        public List<Post> GetAllPost()
        {
            return Database.GetAllPosts();
        }
    }
}
