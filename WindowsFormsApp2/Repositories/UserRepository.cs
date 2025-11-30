using System;
using System.Collections.Generic;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Repositories
{
    public class UserRepository
    {
        private readonly DBClass _dbClass;

        public UserRepository()
        {
            _dbClass = new DBClass();
        }

        public void SaveUsers(List<UserApiModel> users)
        {
            // First, clear existing data or use MERGE. For simplicity, we might clear and re-insert or just insert new ones.
            // The prompt implies "Sync", which often means "Get fresh data".
            // Let's assume we clear and insert for full sync, or just insert/update.
            // Given the DBClass limitation (only ExecuteNonQuery), let's try to Insert.
            // But to avoid PK violation, we should probably delete all first or check existence.
            // Let's go with DELETE ALL then INSERT for "Sync" button simplicity, as requested by "Sync" concept.

            _dbClass.ExecuteNonQuery("DELETE FROM users");

            foreach (var user in users)
            {
                try
                {
                    string name = EscapeString(user.Name);
                    string email = EscapeString(user.Email);
                    string role = EscapeString(user.Role);

                    // Oracle Date format might need attention. sysdate is safe.
                    // For specific date: TO_DATE('2023-01-01', 'YYYY-MM-DD')
                    string createdAt = $"TO_DATE('{user.CreatedAt:yyyy-MM-dd HH:mm:ss}', 'YYYY-MM-DD HH24:MI:SS')";

                    string query = $@"
                        INSERT INTO users (
                            id, name, email, user_level, created_at, posts_count
                        ) VALUES (
                            '{user.Id}', '{name}', '{email}', '{role}', {createdAt}, {user.PostsCount}
                        )";

                    _dbClass.ExecuteNonQuery(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting user {user.Name}: {ex.Message}");
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
