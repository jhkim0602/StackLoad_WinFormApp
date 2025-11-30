using System;

namespace WindowsFormsApp2.Models
{
    /// <summary>
    /// 유저 데이터 모델
    /// </summary>
    public class User
    {
        // DB Column: ID (VARCHAR2)
        public string Id { get; set; }
        
        // DB Column: NAME (VARCHAR2)
        public string Name { get; set; }
        
        // DB Column: EMAIL (VARCHAR2)
        public string Email { get; set; }
        
        // DB Column: USER_LEVEL (VARCHAR2) - Mapped from Role
        public string Role { get; set; }
        
        // DB Column: CREATED_AT (DATE) - Mapped from JoinDate
        public DateTime JoinDate { get; set; }
        
        // DB Column: POSTS_COUNT (NUMBER) - Mapped from Posts
        public int Posts { get; set; }
    }
}
