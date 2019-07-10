using MicroserviceECommerce.MVCUI.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroserviceECommerce.MVCUI.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }


		[HttpGet]
		public ActionResult EmployeeList()
		{
			List<Employees> employees = new List<Employees>();
			employees = HttpHelpers.SendRequest<List<Employees>>("http://localhost:37786", "/api/Employee/GetEmployeeList", Method.GET);
			return View(employees);
		}
	}
}