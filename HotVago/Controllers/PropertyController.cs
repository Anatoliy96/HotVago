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

            return Ok(result);
        }

        [Route("PropertyID")]
        [HttpGet]
        public IActionResult GetByID(int ID)
        {
            PropertyBLL propertyBLL = new PropertyBLL();
            var result = propertyBLL.Get(ID);

            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No such id found" });

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
                //return Ok(propertyBLL);

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

        public IActionResult DeleteProperty(int ID)
        {
            PropertyBLL propertyBLL = new PropertyBLL();
            if (ID.ToString() == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No ID found" });
            }
            else
            {
                propertyBLL.DeleteProperty(ID);
                return Ok(new Response { Status = "Succeeded", Message = "Succesfully delete property" });
            }
        }
    }
}
