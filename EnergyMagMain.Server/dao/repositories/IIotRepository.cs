using EnergyMagMain.Server.dao.entities;

namespace EnergyMagMain.Server.dao.repositories
{
    public interface IIotRepository
    {
        public List<Iot> getAllIot();
        public Iot getIotById(long id);
        public List<Iot> getIotByIpAdress(string ipAddress);
        public List<Iot> GetIotByType(string type);
        public List<Iot> GetIotByManufacturer(string manufacturer);
        public List<Iot> GetIotByStatus(bool status);
    }
}
