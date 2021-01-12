using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;

namespace WebScraperSimplistic
{
    class Program
    {
        static string uriPath = @"https://dsld.od.nih.gov/dsld/prdLabel.jsp?id=56411" + "#prdContact";
        static void Main(string[] args)
        {
            var html = GetHtml();
            Console.WriteLine(html.Result);
        }

        private static async Task<string> GetHtml()
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync(uriPath);
            return await response;
        }
    }
}
