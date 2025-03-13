using EnergyMagMain.Server.dao.entities;

namespace EnergyMagMain.Server.dao.repositories
{
    public interface IEntrepriseRepository
    {
        public List<Entreprise> getAllEntreprises();
        public Entreprise getEntrepriseById(long id);
        public List<Entreprise> GetEntrepriseByName(string name);
        public List<Entreprise> GetEntrepriseByCity(string city);
        public List<Entreprise> GetEntrepriseByCountry(string country);
        public Entreprise GetEntrepriseByCoordinates(double altitude, double longitude);
        public List<Iot> GetIotInEntreprise(Entreprise entreprise);
    }
}
