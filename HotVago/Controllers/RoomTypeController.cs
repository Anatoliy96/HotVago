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
    [Route("api/[Controller]")]
    [ApiController]
    public class RoomTypeController : Controller
    {
        [Route("AllRoomTypes")]
        [HttpGet]
        public IActionResult GetAll()
        {
            RoomTypesBLL roomTypesBLL = new RoomTypesBLL();
            var result = roomTypesBLL.GetAll();
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No data found" });
            }
            else
            {
                return Ok(result);
            }
        }

        [Route("RoomTypeID")]
        [HttpGet]

        public IActionResult Get(int ID)
        {
            RoomTypesBLL roomTypesBLL = new RoomTypesBLL();
            var result = roomTypesBLL.Get(ID);

            if (result == null)
            {
                StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "ID not found" });
            }
            return Ok(result);
        }

        [Route("AddRoomType")]
        [HttpPost]

        public IActionResult Insert(
            string RoomType,
            string Description,
            int RoomID)
        {
            if (RoomType != null)
            {
                RoomTypesBLL roomTypesBLL = new RoomTypesBLL();
                roomTypesBLL.Insert(
                    RoomType,
                    Description,
                    RoomID);

                return Ok(new Response { Status = "Succeed", Message = "Succesfully insert roomtype" });
            }
            else
            {
              return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "RoomType cannot be null" });
            }
        }

        [Route("UpdateRoomType")]
        [HttpPost]

        public IActionResult UpdateRoomType(
            int ID,
            string RoomType,
            string Description,
            int RoomID)
        {
            if (RoomType == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "RoomType not found" });
            }
            else
            {
                RoomTypesBLL roomTypesBLL = new RoomTypesBLL();
                roomTypesBLL.Update(
                    ID,
                    RoomType,
                    Description,
                    RoomID);

                return Ok(new Response { Status = "Succeed", Message = "Succesfully update roomtype" });
            }
        }

        [Route("DeleteRoomType")]
        [HttpDelete]

        public IActionResult DeleteRoomType(int ID)
        {
            if (ID.ToString() == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No ID found" });
            }
            else
            {
                RoomTypesBLL roomTypesBLL = new RoomTypesBLL();
                roomTypesBLL.Delete(ID);

                return Ok(new Response { Status = "Succeed", Message = "Succesfully delete roomtype" });
            }
        }
    }
}
