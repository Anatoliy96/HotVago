using HotVagoBLL.BLL;
using HotVagoDAL.Models;
using HotVagoDAL.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotVago.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PropertyController : Controller
    {
        [Route("AllProperties")]
        [HttpGet]
        public IActionResult GetAll()
        {
            PropertyBLL propertyBLL = new PropertyBLL();
           var result = propertyBLL.GetAll();

            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No data found" });

            return Ok(new Response { Status = "Succeeded", Message = "Data retrive succesfully" });
        }

        [Route("PropertyID")]
        [HttpGet]
        public IActionResult GetByID(int ID)
        {
            PropertyBLL propertyBLL = new PropertyBLL();
            var result = propertyBLL.Get(ID);

            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No id found" });

            //return Ok(new Response { Status = "Succeeded", Message = "Data retrive succesfully" });
            return Ok(result);
        }

        [Route("AddProperty")]
        [HttpPost]

        public IActionResult InsertProperty(
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
            if (PropertyName != null)
            {
                PropertyBLL propertyBLL = new PropertyBLL();
                propertyBLL.AddProperty(
                    PropertyName,
                    Description,
                    Address,
                    City,
                    Country,
                    PostalCode,
                    PhoneNumber,
                    Email,
                    PropertyTypeID);

                return Ok(new Response { Status = "Succeeded", Message = "Property added succesfully" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Property name cannot be null" });
            }
        }

        [Route("UpdateProperty")]
        [HttpPost]

        public IActionResult UpdateProperty(
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
            if (PropertyName == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Property name is not found" });
            }
            else
            {
                PropertyBLL propertyBLL = new PropertyBLL();
                propertyBLL.UpdateProperty(
                    ID,
                    PropertyName,
                    Description,
                    Address,
                    City,
                    Country,
                    PostalCode,
                    PhoneNumber,
                    Email,
                    PropertyTypeID);

                return Ok(new Response { Status = "Succeeded", Message = "Succesfully update property" });
            }
        }

        [Route("DeleteProperty")]
        [HttpDelete]

        public IActionResult DeleteProperty(Property property)
        {
            PropertyBLL propertyBLL = new PropertyBLL();

            if (property == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Cannot delete this property" });
            }
            else
            {
                propertyBLL.DeleteProperty(property);

                return Ok(new Response { Status = "Succeeded", Message = "Succesfully delete property" });
            }
        }
    }
}
