using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotVago.Controllers
{

    public class Dashboard : Controller
    {
        // GET: Dashboard
        public ActionResult GetCounts()
        {

            return View();
        }
    }
}
