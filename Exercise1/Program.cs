using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
	    Console.WriteLine("* Inform about local machine *");
            String host = Dns.GetHostName();
            Console.WriteLine("Computer Name: " + host);

            IPHostEntry iphostentry = Dns.Resolve(host);

            int ipAddr = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP " + ++ipAddr + ": " +
                                  ipaddress.ToString());
            }
        }
    }
}
