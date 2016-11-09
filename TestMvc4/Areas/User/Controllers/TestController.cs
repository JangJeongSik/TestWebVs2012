using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMvc4.Areas.User.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /User/Test/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult TestPage(string p_id)
		{
			string strParam = string.Format("p_id 파라미터 : {0}", p_id);

			



			ViewBag.ParamsStr = strParam;


			return View();
		}


    }
}
