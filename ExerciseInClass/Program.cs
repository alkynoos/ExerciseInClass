using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            home.Name = "My home";
            home.Address = "GoodFaith 8";
            PrintHome print;
            print = (name, address) => $"{name} {address}";
            Console.WriteLine(print(home.Name,home.Address));

        }
        public delegate string PrintHome(string name, string address);
    }
}
