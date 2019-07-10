using MicroserviceECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroserviceECommerce.Customer.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
		RepositoryPattern<Customers> repo = new RepositoryPattern<Customers>(); 

		[HttpGet]
		public List<Customers> CustomersList()
		{
			List<Customers> customer = repo.List();
			  return customer;
		}

		[HttpGet]
		public Customers GetCustomer(string customerid)
		{
			Customers result = repo.Find(x => x.CustomerID == customerid);
			return result;
		}

		[HttpPost]
		public void AddCustomer(Customers customer)
		{

			repo.Add(customer);
		}

		[HttpGet]
		public void DeleteCustomer(string customerid)
		{

			var customer = repo.Find(x => x.CustomerID == customerid);
			repo.Delete(customer);
		}

		[HttpGet]
		public void Login(string customerid)
		{
			repo.Find(x => x.CustomerID ==customerid);
		}

	}
}
