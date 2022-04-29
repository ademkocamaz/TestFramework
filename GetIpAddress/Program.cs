using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetIpAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIpAddress());
            Console.ReadKey();
        }

        private static string GetIpAddress()
        {
            var webClient = new WebClient();
            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;
            webClient.Dispose();
            return dnsString;
        }
    }
}
