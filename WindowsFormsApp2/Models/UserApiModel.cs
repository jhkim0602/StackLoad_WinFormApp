using System;

namespace WindowsFormsApp2.Models
{
    public class UserApiModel
    {
        public int Id { get; set; } // API usually uses int or string. Assuming int based on previous context, but DB uses string 'u1'. Let's stick to string to match DB or int if API generates it. Let's use string to be safe with 'u1'.
        // Wait, the prompt said "id": 1. So API uses int.
        // But local DB uses 'u1'. We need a mapping strategy.
        // For simplicity, let's assume API returns what we need or we map it.
        // Let's use string for Id to be flexible.
        public string IdString { get; set; }

        // Actually, let's follow the prompt example which used int for TechStack.
        // If the local DB has 'u1', 'u2', maybe we should change local DB to use auto-increment int?
        // Or we just map API '1' to Local 'u1'.
        // Let's stick to the properties matching the JSON we will request.

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // Mapped to user_level
        public DateTime CreatedAt { get; set; }
        public int PostsCount { get; set; }
    }
}
