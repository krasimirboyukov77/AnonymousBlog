using AnonymousBlog.Data.Models;
using AnonymousBlog.Data.ViewDataModels;

namespace AnonymousBlog.Contracts
{
    public interface IPostService
    {
        List<Post> GetAllPost();
        bool AddPost(ViewData_Post post);
        bool DeletePost(int id);
    }
}
