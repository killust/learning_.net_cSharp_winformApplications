using System;
using System.Net;

namespace http_traffic_interception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up the proxy server address and port
            string proxyAddress = "127.0.0.1";
            int proxyPort = 8080;

            // Create a new WebProxy instance with the proxy server address and port
            WebProxy proxy = new WebProxy(proxyAddress, proxyPort);

            // Set the default proxy for all WebRequest instances
            WebRequest.DefaultWebProxy = proxy;

            // Make a request to an HTTP or HTTPS resource
            WebRequest request = WebRequest.Create("http://httpforever.com/");
            WebResponse response = request.GetResponse();

            // Read the response data
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string responseData = reader.ReadToEnd();
                Console.WriteLine(responseData);
            }
        }
    }
}

