namespace EnergyMagMain.Server.dao.entities
{
    public class Iot
    {
        public long id { get; }
        public string ipAdress { get; set; }
        public string type { get; set; }
        public string manufacturer { get; set; }
        public string description { get; set; }
        public decimal consumption { get; set; }
        public string precision { get; set; }
        public string measurementRange { get; set; }
        public double load { get; set; }
        public Boolean status { get; set; }
        public List<Issue> issuesList { get; set; }
    }
}
