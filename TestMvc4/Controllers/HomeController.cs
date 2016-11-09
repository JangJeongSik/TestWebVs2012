using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonUtil;

namespace TestMvc4.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			// 서브 모듈 동작 테스트
			string strTest = "90401";
			int iTestVal = strTest.Con_Str_Int32(-1);

			string strViewBagStr = string.Format("ViewBag 값 관련: {0}", iTestVal);

			
			string strDateTime = "2016-01-01 12:40:22";
			DateTime dateViewBag_DateTime_Str = strDateTime.Con_Str_DateTime();

			string strViewBag_DateTime_Str = string.Format("ViewBag 의 DateTime 값 {0}", dateViewBag_DateTime_Str);


			// ViewBag 으로 확인
			ViewBag.TestInt32 = strViewBagStr;
			ViewBag.TestDateTime = strViewBag_DateTime_Str;
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
