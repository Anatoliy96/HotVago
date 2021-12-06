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
    public class RoomTypesBLL
    {
        public List<RoomTypesDTO> GetAll()
        {
            RoomTypeDAO roomTypesDAO = new RoomTypeDAO();
            List<RoomType> roomTypes = (List<RoomType>)roomTypesDAO.GetAll();
            List<RoomTypesDTO> roomTypesDTOs = new List<RoomTypesDTO>();

            foreach (var roomtype in roomTypes)
            {
                CloneData.CloneData<RoomType, RoomTypesDTO> convertor =
                    new CloneData.CloneData<RoomType, RoomTypesDTO>();

                roomTypesDTOs.Add(convertor.CopyData(roomtype));
            }
            return roomTypesDTOs;
        }

        public RoomTypesDTO Get(int ID)
        {
            RoomTypeDAO roomTypeDAO = new RoomTypeDAO();
            RoomType roomType = roomTypeDAO.GetByID(ID);
            RoomTypesDTO roomTypesDTO = new RoomTypesDTO();

            CloneData.CloneData<RoomType, RoomTypesDTO> convertor =
                new CloneData.CloneData<RoomType, RoomTypesDTO>();
            roomTypesDTO = convertor.CopyData(roomType);

            return roomTypesDTO;
        }

        public void Insert(
            string RoomTypes,
            string Description)
        {
            RoomType roomType = new RoomType();

            roomType.RoomTypes = RoomTypes;
            roomType.Description = Description;

            RoomTypeDAO roomTypeDAO = new RoomTypeDAO();
            roomTypeDAO.Add(roomType);
        } 

        public void Update(
            int ID,
            string RoomTypes,
            string Description)
        {
            RoomType roomType = new RoomType();

            roomType.ID = ID;
            roomType.RoomTypes = RoomTypes;
            roomType.Description = Description;

            RoomTypeDAO roomTypeDAO = new RoomTypeDAO();
            roomTypeDAO.Update(roomType);
        }

        public void Delete(int ID)
        {
            RoomTypeDAO roomTypeDAO = new RoomTypeDAO();
            roomTypeDAO.Delete(ID);
        }
    }
}
