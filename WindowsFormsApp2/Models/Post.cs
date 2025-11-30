using System;

namespace WindowsFormsApp2.Models
{
    /// <summary>
    /// 커뮤니티 게시글 데이터 모델
    /// </summary>
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }
    }
}
