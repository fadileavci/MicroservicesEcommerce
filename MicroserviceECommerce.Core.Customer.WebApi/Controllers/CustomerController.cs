using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroserviceECommerce.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceECommerce.Core.Customer.WebApi.Controllers
{
    
    [ApiController]
    public class CustomerController : ControllerBase
    {
		RepositoryPattern<Customers> repo = new RepositoryPattern<Customers>();


		[Route("api/[controller]/[action]")]
		[HttpGet]
		public List<Customers> CustomersList()
		{
			List<Customers> customer = repo.List();
			return customer;
		}

	}

	
}