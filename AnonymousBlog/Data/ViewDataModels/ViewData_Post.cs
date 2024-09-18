using System.ComponentModel.DataAnnotations;

namespace AnonymousBlog.Data.ViewDataModels
{
    public class ViewData_Post
    {
        
        
        [Required(ErrorMessage = "Title is required!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Must be between 1  or 100 characters!")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Description is required!")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Must be between 1  or 500 characters!")]
        public string Description { get; set; } = null!;
        public DateTime DateCreated = DateTime.Now;
    }
}
