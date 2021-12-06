using HotVagoBLL.BLL;
using HotVagoDAL.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotVago.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        [Route("AllRooms")]
        [HttpGet]
        public IActionResult GetAll()
        {
            RoomBLL roomBLL = new RoomBLL();
            var result = roomBLL.GetAll();

            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Rooms not found" });
            }

            return Ok(result);
        }

        [Route("GetRoom")]
        [HttpGet]

        public IActionResult Get(int ID)
        {
            RoomBLL roomBLL = new RoomBLL();
            var result = roomBLL.Get(ID);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No ID found" });
            }
            return Ok(result);
        }

        [Route("AddRoom")]
        [HttpPost]

        public IActionResult InsertRoom(
            int Sleeps,
            decimal Price,
            int NumberOfRooms,
            int PropertyID,
            int RoomTypeID)
        {
            if (Sleeps.ToString() != null)
            {
                RoomBLL roomBLL = new RoomBLL();
                roomBLL.Insert(
                    Sleeps,
                    Price,
                    NumberOfRooms,
                    PropertyID,
                    RoomTypeID);
                return Ok(new Response { Status = "Succeed", Message = "Room inserted succesfully" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "" });
            }
        }

        [Route("UpdateRoom")]
        [HttpPost]

        public IActionResult UpdateRoom(
            int ID,
            int Sleeps,
            decimal Price,
            int NumberOfRooms,
            int PropertyID,
            int RoomTypeID)
        {
            if (ID.ToString() == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No ID found" });
            }
            else
            {
                RoomBLL roomBLL = new RoomBLL();
                roomBLL.Update(
                    ID,
                    Sleeps,
                    Price,
                    NumberOfRooms,
                    PropertyID,
                    RoomTypeID);

                return Ok(new Response { Status = "Succeed", Message = "Succesfully update room" }); 
            }
        }

        [Route("DeleteRoom")]
        [HttpDelete]

        public IActionResult DeleteRoom(int ID)
        {
            if (ID.ToString() == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No ID found"});
            }
            else
            {
                RoomBLL roomBLL = new RoomBLL();
                roomBLL.Delete(ID);
                return Ok(new Response { Status = "Succeed", Message = "Succesfully delete room" });
            }
        }
    }
}
