using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using System.Text;
using System.IO;

namespace WiproWebApp.Utils
{
	public class WebAPI
	{
		public static string URI = "https://localhost:44304/api/";
		public static string TOKEN = "123456";

		public static string RequestGET(string metodo, string parametro)
		{
			var request = (HttpWebRequest)WebRequest.Create(URI + metodo + "/" + parametro);
			//			request.Headers.Add("Token", TOKEN);
			var response = (HttpWebResponse)request.GetResponse();
			var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();
			return responseString;
			//Console.WriteLine("A resposta do método GET é: " + responseString);
		}
		public static string RequestPOST(string metodo, string jsonData)
		{
			var request = (HttpWebRequest)WebRequest.Create(URI + metodo);
			var data = Encoding.ASCII.GetBytes(jsonData);
			request.Method = "POST";
			//			request.Headers.Add("Token", TOKEN);
			request.ContentType = "application/json";
			request.ContentLength = data.Length;
			using (var stream = request.GetRequestStream())
			{
				stream.Write(data, 0, data.Length);
			}
			var response = (HttpWebResponse)request.GetResponse();
			var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
			return responseString;
			//Console.WriteLine("A resposta do método POST é: " + responseString);
		}
	}
}
