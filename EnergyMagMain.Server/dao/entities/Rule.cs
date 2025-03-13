namespace EnergyMagMain.Server.dao.entities
{
    public class Rule
    {
        public long id { get; }
        public string name { get; set; }
        public string description { get; set; }
        public Boolean status { get; set; }
        public string action { get; set; }
        public int precision { get; set; }
        public string level { get; set; }
        public string version { get; set; }
        public DateTime lastUpdate { get; set; }
        public string priority { get; set; }
        public string algotithme { get; set; }
        public int trainingPeriod { get; set; }
        public string impact { get; set; }
        public int rating { get; set; }
    }
}
