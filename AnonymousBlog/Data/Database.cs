using AnonymousBlog.Data.Models;
using AnonymousBlog.Data.ViewDataModels;
using Microsoft.EntityFrameworkCore;

namespace AnonymousBlog.Data
{
    public class Database
    {
        private static ANONYMOUSBLOGDbContext dbContext = new();

        public Database()
        {
            
        }
        public static List<Post> GetAllPosts()
        {
            return dbContext.Posts.ToList();
        }

        public static bool AddPost(ViewData_Post post)
        {
            int countOfPosts = dbContext.Posts.Count();
            Post newPost = new Post()
            {
                
                Title = post.Title,
                Description = post.Description,
                DateCreated = DateTime.Now,
            };
            
            dbContext.Posts.Add(newPost);
            dbContext.SaveChanges();
            bool isAdded = false;
           if(dbContext.Posts.Count()>countOfPosts)
            {
                return true;
            }
           return isAdded;
        }

        public static bool DeletePost(int id)
        {
            Post postToRemove = dbContext.Posts.FirstOrDefault(x => x.Id == id);
            if (postToRemove != null)
            {
                dbContext.Posts.Remove(postToRemove);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
