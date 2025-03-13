using EnergyMagMain.Server.dao.entities;
using EnergyMagMain.Server.dao.repositories;

namespace EnergyMagMain.Server.service
{
    public class IotService : IIotRepository
    {
        List<Iot> _devices;
        public List<Iot> getAllIot()
        {
            return _devices;
        }

        public Iot getIotById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Iot> getIotByIpAdress(string ipAddress)
        {
            throw new NotImplementedException();
        }

        public List<Iot> GetIotByManufacturer(string manufacturer)
        {
            throw new NotImplementedException();
        }

        public List<Iot> GetIotByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public List<Iot> GetIotByType(string type)
        {
            throw new NotImplementedException();
        }

        public void CreateIot(Iot device)
        {
            _devices.Add(device);
        }

        public void UpdateIot(Iot updatedDevice)
        {
            var existingDevice = getIotById(updatedDevice.id);
            if (existingDevice != null)
            {
                existingDevice.ipAdress = updatedDevice.ipAdress;
                existingDevice.type = updatedDevice.type;
                existingDevice.manufacturer = updatedDevice.manufacturer;
                existingDevice.description = updatedDevice.description;
                existingDevice.consumption = updatedDevice.consumption;
                existingDevice.precision = updatedDevice.precision;
                existingDevice.measurementRange = updatedDevice.measurementRange;
                existingDevice.load = updatedDevice.load;
                existingDevice.status = updatedDevice.status;
                existingDevice.issuesList = updatedDevice.issuesList;
            }
        }

        public void DeleteIot(long id)
        {
            var device = getIotById(id);
            if (device != null)
            {
                _devices.Remove(device);
            }
        }
    }
}
