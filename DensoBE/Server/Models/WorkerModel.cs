namespace Server.Models
{
    public class WorkerModel
    {
        public string WorkerId { get; set; } = Guid.NewGuid().ToString();
        public string WorkerName { get; set; }
        public int WorkerAge { get; set; }
        public int WorkerSalary { get; set; }
        public List<StageModel> WorkerStages { get; set; } = new List<StageModel>();
    }
}
