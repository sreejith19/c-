using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo2
    {
        private int num1, num2;
        public Demo2()
        {
            Console.WriteLine("Enter num1:");
            string s = Console.ReadLine();
            num1 = Convert.ToInt32(s);
            Console.WriteLine("Enter num2:");
            s = Console.ReadLine();
            num2 = Convert.ToInt32(s);
        }
        public void demo2()
        {
            Console.WriteLine("sum: "+ (num1 + num2));
        }
        public void demo3()
        {
            if (num2 == 0)
            {
                Console.WriteLine("cannot divide");
                return;
            }
            Console.WriteLine("result of division: " + num1 / num2);
        }
        public static void demo4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35+5)%7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        public void demo5()
        {
            int t = num1;
            num1 = num2;
            num2 = t;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine("First number : " + num1);
            Console.WriteLine("Second number : " + num2);
        }
        public void demo6()
        {
            Console.WriteLine("Enter num3: ");
            string s = Console.ReadLine();
            int num3 = Convert.ToInt32(s);
            Console.WriteLine("product : " + num1 * num2 * num3);
        }
        public void demo7()
        {
            demo2();
            Console.WriteLine("difference: " + (num1 - num2));
            Console.WriteLine("product: " + (num1 * num2));
            demo3();
            mod();
        }
        public void mod()
        {
            if (num2 == 0)
            {
                Console.WriteLine("cannot divide");
                return;
            }
            Console.WriteLine("mod: " + num1 % num2);
        }
    }
}
