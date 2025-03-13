using System.Numerics;

namespace EnergyMagMain.Server.dao.entities
{
    public class Room
    {
        public long id { get; }
        public string name { get; set; }
        public string type { get; set; }
        public List<Iot> roomIots { get; set; }
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }
    }
}
