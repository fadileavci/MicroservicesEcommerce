using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroserviceECommerce.MVCUI
{
	public class HttpHelpers
	{

	
		public static T SendRequest<T>(string host, string resource, Method httpMethod) where T : new()
		{
			var client = new RestClient(host);
			var request = new RestRequest(resource);
			var response = client.Execute<T>(request);
			return response.Data;
		}

		public static T SendRequestid<T>(string host, string resource, Method httpMethod,string id) where T : new()
		{
			var client = new RestClient(host);
			var request = new RestRequest(resource);
			request.AddParameter("customerid", id);
			var response = client.Execute<T>(request);
			return response.Data;
		}

		public static T SendRequestLogin<T>(string host, string resource, Method httpMethod, string customerid ,string password) where T : new()
		{
			var client = new RestClient(host);
			var request = new RestRequest(resource);
			request.AddParameter("customerid", customerid);
			request.AddParameter("password", password);
			var response = client.Execute<T>(request);
			return response.Data;
		}





	}
}