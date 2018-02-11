using System;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;

namespace myApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var client = new RestClient("http://example.com");
            //client.Authenticator = new SimpleAuthenticator("username", "foo", "password", "bar");
            //var request = new RestRequest("resource", Method.GET);
            //var queryResult = client.Execute(request);
            //Console.WriteLine(queryResult.Content);

            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts/1", Method.GET); 
                    
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var queryResult = client.Execute(request);
            Console.WriteLine(queryResult.Content);

            

            

        }
            
    }
}
