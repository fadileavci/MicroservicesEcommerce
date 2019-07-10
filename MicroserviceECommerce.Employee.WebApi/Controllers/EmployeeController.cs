
using MicroserviceECommerce.Employee.WebApi.Models;
using MicroserviceECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroserviceECommerce.Employee.WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
		RepositoryPattern<Employees> repo = new RepositoryPattern<Employees>();

		[HttpGet]
		 public List<ModelEmployee> GetEmployeeList()
		{
			List<Employees> employeelist = repo.List();
			List<ModelEmployee> modelemployeelist = new List<ModelEmployee>();
			foreach(var employee in employeelist)
			{
				ModelEmployee modelemployee = new ModelEmployee
				{
					EmployeeID = employee.EmployeeID,			
					Extension = employee.Extension,
					Address = employee.Address,
					City = employee.City,
					FirstName = employee.FirstName,			
					HomePhone = employee.HomePhone,
					Region = employee.Region,
					PostalCode = employee.PostalCode,
					Country = employee.Country,
					LastName = employee.LastName,
				
					Title = employee.Title,
					TitleOfCourtesy = employee.TitleOfCourtesy,
					ReportsTo = employee.ReportsTo

				};
				modelemployeelist.Add(modelemployee);
			}
			return modelemployeelist;
		}


		public ModelEmployee GetEmployee(int id)
		{
			Employees employee = repo.Find(x=>x.EmployeeID==id);
			ModelEmployee modelemployee = new ModelEmployee
			{
				EmployeeID = employee.EmployeeID,
				
				Extension = employee.Extension,
				Address = employee.Address,
				City = employee.City,
				FirstName = employee.FirstName,
				
				HomePhone = employee.HomePhone,
				Region = employee.Region,
				PostalCode = employee.PostalCode,
				Country = employee.Country,
				LastName = employee.LastName,
			
				Title = employee.Title,
				TitleOfCourtesy = employee.TitleOfCourtesy,
				ReportsTo = employee.ReportsTo

			};
			return modelemployee;
		}



		//[HttpPost]
		//public int Update(Entities.Customer _newCustomer)
		//{
		//	Entities.Customer oldCustomer = data.Customers.FirstOrDefault(x => x.CustomerID == _newCustomer.CustomerID);

		//	oldCustomer.CompanyName = _newCustomer.CompanyName;
		//	oldCustomer.ContactName = _newCustomer.ContactName;
		//	oldCustomer.ContactTitle = _newCustomer.ContactTitle;
		//	oldCustomer.Country = _newCustomer.Country;
		//	oldCustomer.Address = _newCustomer.Address;
		//	oldCustomer.City = _newCustomer.City;
		//	oldCustomer.PostalCode = _newCustomer.PostalCode;
		//	oldCustomer.Phone = _newCustomer.Phone;
		//	oldCustomer.Fax = _newCustomer.Fax;
		//	oldCustomer.Region = _newCustomer.Region;
		//	oldCustomer.Password = _newCustomer.Password;
		//	int result = data.SaveChanges();
		//	return result;
		//}


	}






	
}
