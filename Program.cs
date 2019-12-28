using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace IdentityDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
          /*  var client = new RestClient("https://indeed-indeed.p.rapidapi.com/apisearch?q=java&v=2&format=json&radius=25&l=france&publisher=indeed");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "indeed-indeed.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "1914e331d0msh421217434bf4047p1b7f32jsn3a7b5ec2c126");
            IRestResponse response = client.Execute(request);*/

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
