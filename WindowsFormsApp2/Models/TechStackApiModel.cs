using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Models
{
    // API 응답 구조에 맞춘 모델 클래스
    public class TechStackApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public int Popularity { get; set; }
        public string LearningResources { get; set; } // JSON string or handle as object if needed
        public string AiExplanation { get; set; }
        public string Homepage { get; set; }
        public string Repo { get; set; }
        public string ProjectSuitability { get; set; } // JSON string
        public string LearningDifficulty { get; set; } // JSON string
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
