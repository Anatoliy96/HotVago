using HotVagoBLL.BLL.DTO;
using HotVagoDAL.DAO;
using HotVagoDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL
{
    public class PropertyBLL
    {
        public List<PropertyDTO> GetAll()
        {
            PropertyDAO propertyDAO = new PropertyDAO();
            List<Property> properties = propertyDAO.GetDbSet().Include(p => p.PropertyType).ToList();
            List<PropertyDTO> propertyDTO = new List<PropertyDTO>();

            foreach (var p in properties)
            {
                CloneData.CloneData<Property, PropertyDTO> convertor =
                    new CloneData.CloneData<Property, PropertyDTO>();
                PropertyDTO dto = convertor.CopyData(p);
                dto.PropertyType = p.PropertyType;
                propertyDTO.Add(dto);
            }

            return propertyDTO;
        }

        public PropertyDTO Get(int ID)
        {
            PropertyDAO propertyDAO = new PropertyDAO();
            Property property = propertyDAO.GetByID(ID);
            PropertyDTO propertyDTO = new PropertyDTO();

            CloneData.CloneData<Property, PropertyDTO> Convertor =
                new CloneData.CloneData<Property, PropertyDTO>();
            propertyDTO = Convertor.CopyData(property);

            return propertyDTO;
        }

        public void AddProperty(
            string PropertyName,
            string Description,
            string Address,
            string City,
            string Country,
            int PostalCode,
            int PhoneNumber,
            string Email,
            int PropertyTypeID)
        {
            Property property = new Property();

            property.PropertyName = PropertyName;
            property.Description = Description;
            property.Address = Address;
            property.City = City;
            property.County = Country;
            property.PostalCode = PostalCode;
            property.PhoneNumber = PhoneNumber;
            property.Email = Email;
            property.PropertyTypeID = PropertyTypeID;

            PropertyDAO propertyDAO = new PropertyDAO();

            propertyDAO.Add(property);
        }

        public void UpdateProperty(
            int ID,
            string PropertyName,
            string Description,
            string Address,
            string City,
            string Country,
            int PostalCode,
            int PhoneNumber,
            string Email,
            int PropertyTypeID)
        {
            Property property = new Property();

            property.ID = ID;
            property.PropertyName = PropertyName;
            property.Description = Description;
            property.Address = Address;
            property.City = City;
            property.County = Country;
            property.PostalCode = PostalCode;
            property.PhoneNumber = PhoneNumber;
            property.Email = Email;
            property.PropertyTypeID = PropertyTypeID;

            PropertyDAO propertyDAO = new PropertyDAO();
            propertyDAO.Update(property);
        }

        public void DeleteProperty(int ID)
        {
            PropertyDAO propertyDAO = new PropertyDAO();
            propertyDAO.Delete(ID);
        }
    }
}
