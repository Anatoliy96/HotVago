using HotVagoBLL.BLL.DTO;
using HotVagoDAL.DAO;
using HotVagoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL
{
   public class RoomBLL
    {
        public List<RoomDTO> GetAll()
        {
            RoomDAO roomDAO = new RoomDAO();
            List<Room> rooms = (List<Room>)roomDAO.GetAll();
            List<RoomDTO> roomDTOs = new List<RoomDTO>();

            foreach (var room in rooms)
            {
                CloneData.CloneData<Room, RoomDTO> convertor =
                    new CloneData.CloneData<Room, RoomDTO>();
                roomDTOs.Add(convertor.CopyData(room));
            }
            return roomDTOs;
        }

        public RoomDTO Get(int ID)
        {
            RoomDAO roomDAO = new RoomDAO();
            Room room = roomDAO.GetByID(ID);
            RoomDTO roomDTOs = new RoomDTO();

            CloneData.CloneData<Room, RoomDTO> convertor =
                new CloneData.CloneData<Room, RoomDTO>();
            roomDTOs = convertor.CopyData(room);

            return roomDTOs;
        }

        public void Insert(
            int Sleeps,
            decimal Price,
            int NumberOfRooms)
        {
            Room room = new Room();
            room.Sleeps = Sleeps;
            room.Price = Price;
            room.NumberOfRooms = NumberOfRooms;

            RoomDAO roomDAO = new RoomDAO();
            roomDAO.Add(room);
        }

        public void Update(
            int ID,
            int Sleeps,
            decimal Price,
            int NumberOfRooms)
        {
            Room room = new Room();
            room.ID = ID;
            room.Sleeps = Sleeps;
            room.Price = Price;
            room.NumberOfRooms = NumberOfRooms;

            RoomDAO roomDAO = new RoomDAO();
            roomDAO.Update(room);
        }

        public void Delete(int ID)
        {
            RoomDAO roomDAO = new RoomDAO();
            roomDAO.Delete(ID);
        }
    }
}
