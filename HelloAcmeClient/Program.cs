using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAcmeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloAcmeService.HelloServiceClient proxy = new HelloAcmeService.HelloServiceClient();

            var msg = proxy.GetData(101);

            Console.Write(msg);
            Console.ReadLine();
        }
    }
}
