using EnergyMagMain.Server.dao.entities;
using EnergyMagMain.Server.dao.repositories;

namespace EnergyMagMain.Server.service
{
    public class RoomService : IRoomRepository
    {
        List<Room> _rooms = new List<Room>();

        public List<Room> getAllRooms()
        {
            throw new NotImplementedException();
        }

        public List<Iot> GetIotInRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Room getRoomById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetRoomByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetRoomByType(string type)
        {
            throw new NotImplementedException();
        }

        public double GetRoomVolume(Room room)
        {
            throw new NotImplementedException();
        }
        public void CreateRoom(Room room)
        {
            _rooms.Add(room);
        }

        public void UpdateRoom(Room updatedRoom)
        {
            var existingRoom = getRoomById(updatedRoom.id);
            if (existingRoom != null)
            {
                existingRoom.name = updatedRoom.name;
                existingRoom.type = updatedRoom.type;
                existingRoom.roomIots = updatedRoom.roomIots;
                existingRoom.length = updatedRoom.length;
                existingRoom.width = updatedRoom.width;
                existingRoom.height = updatedRoom.height;
            }
        }

        public void DeleteRoom(long id)
        {
            var room = getRoomById(id);
            if (room != null)
            {
                _rooms.Remove(room);
            }
        }
    }
}
