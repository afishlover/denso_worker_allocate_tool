namespace Server.Models
{
    public class LineModel
    {
        public string LineId { get; set; } = Guid.NewGuid().ToString();
        public string LineName { get; set; } 

    }
}
