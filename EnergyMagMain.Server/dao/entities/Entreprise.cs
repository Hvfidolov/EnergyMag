namespace EnergyMagMain.Server.dao.entities
{
    public class Entreprise
    {
        public long id { get; }
        public string name { get; set; }
        public string city { get; set; }
        public double altitude { get; set; }
        public double longitude { get; set; }
        public string objective { get; set; }
        public int numberOfEmployees { get; set; }
        public string email { get; set; }
        public List<Iot> entrepriseIots { get; set; }
        public List<Room> entrepriseRooms { get; set; }
    }
}
