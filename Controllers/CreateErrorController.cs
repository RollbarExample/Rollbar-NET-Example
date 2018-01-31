using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RollbarDotnetExample.Controllers
{
    public class CreateErrorController : Controller
    {
        // GET: CreateError
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GenerateError()
        {

            throw new Exception("This is test exception");

        }

    }
}