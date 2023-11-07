namespace Server.Models
{
    public class StageModel
    {
        public string StageId { get; set; } = Guid.NewGuid().ToString();
        public string StageName { get; set; }
        public int StageScore { get; set; }
    }
}
