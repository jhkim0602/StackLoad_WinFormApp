namespace WindowsFormsApp2.Models
{
    /// <summary>
    /// 기술 스택 데이터 모델
    /// </summary>
    public class TechStack
    {
        // DB Column: ID (NUMBER)
        public int Id { get; set; }

        // DB Column: NAME (VARCHAR2)
        public string Name { get; set; }

        // DB Column: CATEGORY (VARCHAR2)
        public string Category { get; set; }

        // DB Column: DESCRIPTION (VARCHAR2)
        public string Description { get; set; }

        // DB Column: POPULARITY (NUMBER) - Mapped from UserCount
        public int UserCount { get; set; }
        
        // Version removed as it doesn't exist in DB table 'techs'
    }
}
