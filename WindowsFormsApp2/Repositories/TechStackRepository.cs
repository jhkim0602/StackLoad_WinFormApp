using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Repositories
{
    public class TechStackRepository
    {
        private readonly DBClass _dbClass;

        public TechStackRepository()
        {
            _dbClass = new DBClass();
        }

        public void SaveTechStacks(List<TechStackApiModel> stacks)
        {
            foreach (var stack in stacks)
            {
                try
                {
                    // 문자열 이스케이프 처리 (SQL Injection 방지 및 오류 방지)
                    string name = EscapeString(stack.Name);
                    string slug = EscapeString(stack.Slug);
                    string category = EscapeString(stack.Category);
                    string description = EscapeString(stack.Description);
                    string logoUrl = EscapeString(stack.LogoUrl);
                    string learningResources = EscapeString(stack.LearningResources);
                    string aiExplanation = EscapeString(stack.AiExplanation);
                    string homepage = EscapeString(stack.Homepage);
                    string repo = EscapeString(stack.Repo);
                    string projectSuitability = EscapeString(stack.ProjectSuitability);
                    string learningDifficulty = EscapeString(stack.LearningDifficulty);

                    string query = $@"
                        INSERT INTO techs (
                            id, name, slug, category, description, logo_url, popularity,
                            learning_resources, ai_explanation, homepage, repo,
                            project_suitability, learning_difficulty, created_at, updated_at
                        ) VALUES (
                            {stack.Id}, '{name}', '{slug}', '{category}', '{description}', '{logoUrl}', {stack.Popularity},
                            '{learningResources}', '{aiExplanation}', '{homepage}', '{repo}',
                            '{projectSuitability}', '{learningDifficulty}', sysdate, sysdate
                        )";

                    _dbClass.ExecuteNonQuery(query);
                }
                catch (Exception ex)
                {
                    // 개별 삽입 실패 시 로그를 남기거나 계속 진행
                    Console.WriteLine($"Error inserting stack {stack.Name}: {ex.Message}");
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
