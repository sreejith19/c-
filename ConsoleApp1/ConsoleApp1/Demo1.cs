using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo1
    {
        private string name;
        public Demo1()
        {
            Console.WriteLine("Enter your name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Hello : {0}", this.name);
        }
    }
}
