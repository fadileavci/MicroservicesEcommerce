using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroserviceECommerce.CoreUI.Entities;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace MicroserviceECommerce.CoreUI.Controllers
{
    public class CustomerController : Controller
    {
       


		[HttpGet]
		public ActionResult CustomerList()
		{
			List<Customers> customers = new List<Customers>();
			customers = HttpHelpers.SendRequest<List<Customers>>("http://localhost:37776", "api/Customer/CustomersList", Method.GET);
			return View(customers);
		}


	}


}