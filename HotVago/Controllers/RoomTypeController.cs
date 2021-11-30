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
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            RoomTypesBLL roomTypesBLL = new RoomTypesBLL();
            var result = roomTypesBLL.GetAll();
            if (result== null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "No data found" });
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
