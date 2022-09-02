using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo8
    {
        private int num;
        public Demo8()
        {
            Console.WriteLine("Enter number: ");
            num = readNum();
            //table();
        }
        private int readNum()
        {
            return Convert.ToInt32(Console.ReadLine());

        }
        public void demo8()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " X " + num + " = " + i * num);
            }
        }
        public void demo9()
        {
            int num1 = num;
            Console.WriteLine("Enter the Second number: ");
            int num2 = readNum();
            Console.WriteLine("Enter the third number: ");
            int num3 = readNum();
            Console.WriteLine("Enter the four number: ");
            int num4 = readNum();
            Console.WriteLine("Average: " + (num1 + num2 + num3 + num4) / 4);
        }
        public void demo10()
        {
            int x = num;
            Console.WriteLine("Enter the Second number: ");
            int y = readNum();
            Console.WriteLine("Enter the third number: ");
            int z = readNum();
            Console.WriteLine(" (x+y).z = "+(x+y)*z);
            Console.WriteLine(" x.y+y.z = " + (x * y + y * z));
        }
    }
}
