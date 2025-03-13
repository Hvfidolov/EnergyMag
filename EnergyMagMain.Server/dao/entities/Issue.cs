namespace EnergyMagMain.Server.dao.entities
{
    public class Issue
    {
        public int id { get; }
        public string type { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool issueStatus { get; set; }
        public string response { get; set; }
    }
}
