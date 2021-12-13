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
    public class FacilityTypeBLL
    {
        public List<FacilityTypeDTO> GetAll()
        {
            FacilityTypeDAO facilityTypeDAO = new FacilityTypeDAO();
            List<FacilityType> facilityTypes = (List<FacilityType>)facilityTypeDAO.GetAll();
            List<FacilityTypeDTO> facilityTypeDTOs = new List<FacilityTypeDTO>();

            foreach (var f in facilityTypes)
            {
                CloneData.CloneData<FacilityType, FacilityTypeDTO> convertor =
                    new CloneData.CloneData<FacilityType, FacilityTypeDTO>();

                facilityTypeDTOs.Add(convertor.CopyData(f));
            }
            return facilityTypeDTOs;
        }

        public FacilityTypeDTO Get(int ID)
        {
            FacilityTypeDAO facilityTypeDAO = new FacilityTypeDAO();
            FacilityType facilityType = facilityTypeDAO.GetByID(ID);
            FacilityTypeDTO facilityTypeDTO = new FacilityTypeDTO();

            CloneData.CloneData<FacilityType, FacilityTypeDTO> convertor =
                new CloneData.CloneData<FacilityType, FacilityTypeDTO>();

            facilityTypeDTO = convertor.CopyData(facilityType);
            return facilityTypeDTO;
        }
    }
}
