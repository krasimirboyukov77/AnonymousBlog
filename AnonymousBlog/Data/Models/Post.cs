using System.ComponentModel.DataAnnotations;

namespace AnonymousBlog.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime DateCreated { get; set; }
    }
}
