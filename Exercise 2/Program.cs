using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
	    Console.Write("Enter Host Name or IP address: ");
            string host = Console.ReadLine();

            IPHostEntry ip = Dns.Resolve(host);
            Console.WriteLine("Host Name: {0}", ip.HostName);

            // Output Hostname
            foreach (string a in ip.Aliases)
                Console.WriteLine("\t+ Alias: {0} \n", a);

            // Output TP list
            foreach (IPAddress i in ip.AddressList)
                Console.WriteLine("\t+ IP: {0}", i);
        }
    }
}