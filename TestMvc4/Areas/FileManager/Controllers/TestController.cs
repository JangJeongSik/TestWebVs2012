using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMvc4.Areas.FileManager.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /FileManager/Test/

        public ActionResult Index()
        {
            return View();
        }

    }
}
