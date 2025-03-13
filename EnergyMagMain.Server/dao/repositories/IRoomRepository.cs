using EnergyMagMain.Server.dao.entities;

namespace EnergyMagMain.Server.dao.repositories
{
    public interface IRoomRepository
    {
        public List<Room> getAllRooms();
        public Room getRoomById(long id);
        public List<Room> GetRoomByName(string name);
        public List<Room> GetRoomByType(string type);
        public List<Iot> GetIotInRoom(Room room);
        public double GetRoomVolume(Room room);
    }
}
