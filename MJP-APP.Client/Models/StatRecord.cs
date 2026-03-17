namespace MJP_APP.Client.Models
{
    public class StatRecord
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "Névtelen";
        public string GameName { get; set; } = "";
        public int Score { get; set; }
        public int DurationSeconds { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}