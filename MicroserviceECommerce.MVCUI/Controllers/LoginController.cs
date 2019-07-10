using MicroserviceECommerce.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroserviceECommerce.MVCUI.Views.Customer
{
    public class LoginController : Controller
    {

		[HttpGet]
		public ActionResult Login()
		{
			return View();
		}


		[HttpPost]//433
		public ActionResult Login(string customerid, string password)
		{
			Customers customers = new Customers();
			customers = HttpHelpers.SendRequestLogin<Customers>("http://localhost:37776", "api/Customer/Login", Method.GET, customerid, password);
			if (customers.Password == password)
			{
				Session["login"] = customers;
				return RedirectToAction("CustomerList", "Customer");
			}
			return RedirectToAction("Hataa");
		}

	}
}