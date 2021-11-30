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
        public List<RoomTypesStatusDTO> GetAll()
        {
            RoomTypeDAO roomTypesDAO = new RoomTypeDAO();
            List<RoomType> roomTypes = (List<RoomType>)roomTypesDAO.GetAll();
            List<RoomTypesStatusDTO> roomTypesDTOs = new List<RoomTypesStatusDTO>();

            foreach (RoomType roomtype in roomTypes)
            {
                CloneData.CloneData<RoomType, RoomTypesStatusDTO> convertor =
                    new CloneData.CloneData<RoomType, RoomTypesStatusDTO>();
                roomTypesDTOs.Add(convertor.CopyData(roomtype));
                RoomTypesStatusDTO statusDTO = new RoomTypesStatusDTO();

                if (statusDTO.IsActive == true)
                {
                    statusDTO.RoomStatus = "Free";
                }

                if(statusDTO.IsActive == false)
                {
                    statusDTO.RoomStatus = "Reserved";
                }
                roomTypesDTOs.Add(statusDTO);
            }
            return roomTypesDTOs;
        }


    }
}
