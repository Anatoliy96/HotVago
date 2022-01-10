using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotVagoBLL.BLL.BLO.Dashboard;

namespace HotVago.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Dashboard : Controller
    {
        // GET: Dashboard
        [Route("AllCounts")]
        [HttpGet]
        public ActionResult GetCounts()
        {
            HotVagoBLL.BLL.BLO.Dashboard.Dashboard dashboard = new HotVagoBLL.BLL.BLO.Dashboard.Dashboard();
            return Ok(dashboard.GetDashboardViewModel());
        }
    }
}
