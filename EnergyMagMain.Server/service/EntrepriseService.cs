using EnergyMagMain.Server.dao.entities;
using EnergyMagMain.Server.dao.repositories;

namespace EnergyMagMain.Server.service
{
    public class EntrepriseService : IEntrepriseRepository
    {
        List <Entreprise> entreprises = new List<Entreprise>();
        public List<Entreprise> getAllEntreprises()
        {
            return entreprises;
        }

        public List<Entreprise> GetEntrepriseByCity(string city)
        {
            throw new NotImplementedException();
        }
        public List<Entreprise> GetEntrepriseByName(string name)
        {
            throw new NotImplementedException();
        }

        public Entreprise GetEntrepriseByCoordinates(double altitude, double longitude)
        {
            throw new NotImplementedException();
        }

        public List<Entreprise> GetEntrepriseByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public Entreprise getEntrepriseById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Iot> GetIotInEntreprise(Entreprise entreprise)
        {
            throw new NotImplementedException();
        }
        public void CreateEntreprise(Entreprise entreprise)
        {
            entreprises.Add(entreprise);
        }

        public void UpdateEntreprise(Entreprise updatedEntreprise)
        {
            var existingEntreprise = getEntrepriseById(updatedEntreprise.id);
            if (existingEntreprise != null)
            {
                existingEntreprise.name = updatedEntreprise.name;
                existingEntreprise.city = updatedEntreprise.city;
                existingEntreprise.altitude = updatedEntreprise.altitude;
                existingEntreprise.longitude = updatedEntreprise.longitude;
                existingEntreprise.objective = updatedEntreprise.objective;
                existingEntreprise.numberOfEmployees = updatedEntreprise.numberOfEmployees;
                existingEntreprise.email = updatedEntreprise.email;
                existingEntreprise.entrepriseIots = updatedEntreprise.entrepriseIots;
                existingEntreprise.entrepriseRooms = updatedEntreprise.entrepriseRooms;
            }
        }

        public void DeleteEntreprise(long id)
        {
            var entreprise = getEntrepriseById(id);
            if (entreprise != null)
            {
                entreprises.Remove(entreprise);
            }
        }
    }
}
