using MicroserviceECommerce.MVCUI.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroserviceECommerce.MVCUI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
		[HttpGet]
        public ActionResult CustomerList()
        {
			List<Customers> customers = new List<Customers>();
			customers = HttpHelpers.SendRequest<List<Customers>>("http://localhost:37776", "api/Customer/CustomersList", Method.GET) ;
			return View(customers);
        }
		
		public ActionResult CustomerDelete(string id)
		{
			Customers customers = new Customers();
			customers = HttpHelpers.SendRequestid<Customers>("http://localhost:37776", "api/Customer/DeleteCustomer", Method.GET,id);
			return RedirectToAction("CustomerList");
		}

		[HttpGet]
		public ActionResult AddCustomer()
		{
			return View(new Customers());
		}

		[HttpPost]
		public ActionResult AddCustomer(Customers cus)
		{

			cus.CustomerID = cus.CompanyName.Substring(0,5);
			var client = new RestClient("http://localhost:37776/");
			var request = new RestRequest("api/Customer/AddCustomer", Method.POST);
			request.AddJsonBody(cus);
			client.Execute(request);
			return RedirectToAction("CustomerList");
			
		}

		public ActionResult GetCustomerDetail(string id)
		{
			Customers customers = new Customers();
			customers = HttpHelpers.SendRequestid<Customers>("http://localhost:37776", "api/Customer/GetCustomer", Method.GET, id);
			return View(customers);
		}

	




	}
}