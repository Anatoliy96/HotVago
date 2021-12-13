using HotVagoBLL.BLL;
using HotVagoDAL.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotVago.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class GuestController : Controller
    {
        [Route("AllGuest")]
        [HttpGet]
        public IActionResult GetAllGuests()
        {
            GuestBLL guestBLL = new GuestBLL();
            var result = guestBLL.GetAll();
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No Guests found" });
            }
            return Ok(result);
        }

        [Route("GuestID")]
        [HttpGet]
        public IActionResult GetByID(int ID)
        {
            GuestBLL guestBLL = new GuestBLL();
            var result = guestBLL.Get(ID);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No ID found"});
            }
            return Ok(result);
        }
        [Route("AddGuest")]
        [HttpPost]
        public IActionResult InsertGuest(
            string FirstName,
            string LastName,
            string Email,
            int PhoneNumber)
        {
            GuestBLL guestBLL = new GuestBLL();
            if (FirstName != null)
            {
                guestBLL.Insert(
                    FirstName,
                    LastName,
                    Email,
                    PhoneNumber);

                return Ok(new Response { Status = "Succeed", Message = "Guest inserted succesfully" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Guest name cannot be null" });
            }
        }

        [Route("UpdateGuest")]
        [HttpPost]

        public IActionResult UpdateGuest(
            int ID,
            string FirstName,
            string LastName,
            string Email,
            int PhoneNumber)
        {
            if (FirstName == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Guest name is not found" });
            }
            else
            {
                GuestBLL guestBLL = new GuestBLL();
                guestBLL.Update(
                    ID,
                    FirstName, 
                    LastName, 
                    Email, 
                    PhoneNumber);

                return Ok(new Response { Status = "Succeed", Message = "Guest update succesfully" });
            }
        }

        [Route("DeleteGuest")]
        [HttpDelete]

        public IActionResult DeleteGuest(int ID)
        {
            if (ID.ToString() == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No ID found"});
            }
            else
            {
                GuestBLL guestBLL = new GuestBLL();
                guestBLL.Delete(ID);

                return Ok(new Response { Status = "Succeed", Message = "Succesfully delete guest" });
            }
        }
    }
}
