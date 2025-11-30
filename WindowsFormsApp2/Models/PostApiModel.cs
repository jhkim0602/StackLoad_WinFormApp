using System;

namespace WindowsFormsApp2.Models
{
    public class PostApiModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; } // API might return Author object or ID. Let's assume ID.
        public string PostType { get; set; } // Category
        public DateTime CreatedAt { get; set; }
        public int ViewsCount { get; set; }
        public int CommentsCount { get; set; }
    }
}
