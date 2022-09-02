using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Demo1
    {
        private int readNum()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public void demo1()
        {
            Console.WriteLine("Enter num1:");
            int num1 = readNum();
            Console.WriteLine("Enter num2:");
            int num2 = readNum();
            if (num1 == num2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public void demo2()
        {
            Console.WriteLine("Enter num:");
            int num = readNum();
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        public void demo3()
        {
            Console.WriteLine("Enter num:");
            int num = readNum();
            if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Neither");
            }
        }
        public void demo4()
        {
            Console.WriteLine("Enter year:");
            int num = readNum();
            if (num % 400 == 0)
            {
                Console.WriteLine("Leap");
            }
            else if (num % 100 == 0)
            {
                Console.WriteLine("Non-leap");
            }
            else if (num % 4 == 0)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Non-leap");
            }
        }
        public void demo5()
        {
            Console.WriteLine("Enter age:");
            int num = readNum();
            if (num >= 18)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
        public void demo6()
        {
            Console.WriteLine("Enter num:");
            int num = readNum();
            if (num < 0)
            {
                Console.WriteLine("n = -1");
            }
            else if (num > 0)
            {
                Console.WriteLine("n = 1");
            }
            else
            {
                Console.WriteLine("n = 0");
            }
        }
        public void demo7()
        {
            Console.WriteLine("Enter height(cm):");
            int num = readNum();
            if (num <=135)
            {
                Console.WriteLine("Dwarf");
            }
            else if (num <=150)
            {
                Console.WriteLine("Short");
            }
            else if (num <=180)
            {
                Console.WriteLine("Average");
            }
            else if(num<200)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Giant");
            }
        }
        public void demo8()
        {
            Console.WriteLine("Enter num1:");
            int num1 = readNum();
            Console.WriteLine("Enter num2:");
            int num2 = readNum();
            Console.WriteLine("Enter num3:");
            int num3 = readNum();

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("largest: " + num1);
                }
                else
                {
                    Console.WriteLine("largest: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("largest: " + num2);
                }
                else
                {
                    Console.WriteLine("largest: " + num3);
                }
            }
        }
        public void demo9()
        {
            Console.WriteLine("Enter X:");
            int x = readNum();
            Console.WriteLine("Enter Y:");
            int y = readNum();

            if (x >= 0)
            {
                if (y >= 0)
                {
                    Console.WriteLine("1st quadrant");
                }
                else
                {
                    Console.WriteLine("4th quadrant");
                }
            }
            else
            {
                if (y >= 0)
                {
                    Console.WriteLine("2nd quadrant");
                }
                else
                {
                    Console.WriteLine("3rd quadrant");
                }
            }
        }
        public void demo10()
        {
            Console.WriteLine("Enter mark for physics:");
            int p = readNum();
            Console.WriteLine("Enter mark for chemistry:");
            int c = readNum();
            Console.WriteLine("Enter mark for maths:");
            int m = readNum();
            if (p >= 55 && c >= 50 && m >= 65)
            {
                if (p + c + m >= 180)
                {
                    Console.WriteLine("Eligible");
                    return;
                }
                if(m+p>=140 || m + c >= 140)
                {
                    Console.WriteLine("Eligible");
                    return;
                }
            }
            Console.WriteLine("Not eligible");
        }
        public void demo11()
        {
            Console.WriteLine("Terms: ");
            int n = readNum();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Number: " + i + " Cube: " + i * i * i);
            }
        }
        public void demo12()
        {
            Console.WriteLine("Number: ");
            int n = readNum();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " X " + i + " = " + i * n);
            }
        }
        public void demo13()
        {
            Console.WriteLine("Number: ");
            int n = readNum();
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write(" "+i + " X " + j + " = " + i * j);
                }
                Console.WriteLine();
            }
        }
        public void demo14()
        {
            Console.WriteLine("Number: ");
            int n = readNum();
            for (int i = 1; i <= 2*n; i+=2)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();
            Console.WriteLine("Sum: "+n*n);
        }
        public void demo15()
        {
            Console.WriteLine("Lines: ");
            int n = readNum();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
        }
        public void demo16()
        {
            Console.WriteLine("Lines: ");
            int n = readNum();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" "+j);
                }
            }
        }
        public void demo17()
        {
            Console.WriteLine("Lines: ");
            int n = readNum();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + i);
                }
            }
        }
        public void demo18()
        {
            Console.WriteLine("Lines: ");
            int n = readNum();
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + k++);
                }
            }
        }
        public void demo19()
        {
            Console.WriteLine("Lines: ");
            int n = readNum();
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for(int l = 0; l < n - i; l++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + k++);
                }
            }
        }
        public void demo20()
        {
            Console.WriteLine("Lines: ");
            int n = readNum();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int l = 0; l < n - i; l++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
            }
        }
    }
}
