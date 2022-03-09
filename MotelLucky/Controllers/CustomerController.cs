using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotelLucky.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("customer")]
        public ActionResult Index()
        {
            return View();
        }
    }
}