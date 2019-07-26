using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryResourceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Resource1.hello = {Resource1.hello}");
            if (Resource1.hello == null)
            {
                Console.WriteLine("Is null");
            }
        }
    }
}
