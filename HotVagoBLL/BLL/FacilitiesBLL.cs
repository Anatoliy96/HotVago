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
    public class FacilitiesBLL
    {
        public List<FacilityDTO> GetAll()
        {
            FacilitiesDAO facilitiesDAO = new FacilitiesDAO();
            List<Facilities> facilities = (List<Facilities>)facilitiesDAO.GetAll();
            List<FacilityDTO> facilityDTOs = new List<FacilityDTO>();

            foreach (var f in facilities)
            {
                CloneData.CloneData<Facilities, FacilityDTO> convertor =
                    new CloneData.CloneData<Facilities, FacilityDTO>();

                facilityDTOs.Add(convertor.CopyData(f));
            }

            return facilityDTOs;
        }

        public FacilityDTO Get(int ID)
        {
            FacilitiesDAO facilitiesDAO = new FacilitiesDAO();
            Facilities facilities = facilitiesDAO.GetByID(ID);
            FacilityDTO facilityDTO = new FacilityDTO();

            CloneData.CloneData<Facilities, FacilityDTO> convertor =
                new CloneData.CloneData<Facilities, FacilityDTO>();

            facilityDTO = convertor.CopyData(facilities);

            return facilityDTO;
        }
    }
}
