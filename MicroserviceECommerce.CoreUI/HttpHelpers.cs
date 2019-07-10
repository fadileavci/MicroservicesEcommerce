using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceECommerce.CoreUI
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

	}
}
