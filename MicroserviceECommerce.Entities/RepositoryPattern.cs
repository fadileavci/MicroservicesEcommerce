using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceECommerce.Entities
{
	public class RepositoryPattern<T>  where  T:class

	{
		DataContext db = new DataContext();
		
		public List<T> List()
		{
			return db.Set<T>().ToList();
		}

		public List<T> List(Expression<Func<T, bool>> where)
		{
			return db.Set<T>().Where(where).ToList();
		}

		public T Find(Expression<Func<T, bool>> where)
		{
			return db.Set<T>().FirstOrDefault(where);
		}

		public void Add(T obj)
		{
			db.Set<T>().Add(obj);
			db.SaveChanges();
		}

		public void Delete(T obj)
		{
			
			db.Set<T>().Remove(obj);
			db.SaveChanges();
		}


	

		//public List<customerDTO> ListCustomers()

		//{
		//	List<customerDTO> customers = db.Customers.Select(x => new customerDTO()
		//	{
		//		Address = x.Address,
		//		City = x.City,
		//		CompanyName = x.CompanyName,
		//		CustomerID = x.CustomerID,
		//		Password = x.Password,
		//		Phone = x.Phone,
		//		ContactName = x.ContactName,
		//		Country = x.Country,
		//		ContactTitle = x.ContactTitle,
		//	}).ToList();

		//	return customers;
		//}
	}
}
