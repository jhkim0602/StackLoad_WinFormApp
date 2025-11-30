using System;
using System.Collections.Generic;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Repositories
{
    public class PostRepository
    {
        private readonly DBClass _dbClass;

        public PostRepository()
        {
            _dbClass = new DBClass();
        }

        public void SavePosts(List<PostApiModel> posts)
        {
            _dbClass.ExecuteNonQuery("DELETE FROM posts");

            foreach (var post in posts)
            {
                try
                {
                    string title = EscapeString(post.Title);
                    string authorId = EscapeString(post.AuthorId);
                    string postType = EscapeString(post.PostType);

                    string createdAt = $"TO_DATE('{post.CreatedAt:yyyy-MM-dd HH:mm:ss}', 'YYYY-MM-DD HH24:MI:SS')";

                    string query = $@"
                        INSERT INTO posts (
                            id, title, author_id, post_type, created_at, views_count, comments_count
                        ) VALUES (
                            {post.Id}, '{title}', '{authorId}', '{postType}', {createdAt}, {post.ViewsCount}, {post.CommentsCount}
                        )";

                    _dbClass.ExecuteNonQuery(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting post {post.Title}: {ex.Message}");
                }
            }
        }

        private string EscapeString(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            return input.Replace("'", "''");
        }
    }
}
