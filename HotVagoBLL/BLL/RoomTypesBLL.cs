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

        public enum status
        {
            Free,
            Reserved
        }
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

                RoomTypesStatusDTO statusDTO = new RoomTypesStatusDTO();

                if (statusDTO.IsActive == true)
                {
                    statusDTO.RoomStatus = status.Free.ToString();
                }

                else
                {
                    statusDTO.RoomStatus = status.Reserved.ToString();
                }
            }
            return roomTypesDTOs;
        }


    }
}
