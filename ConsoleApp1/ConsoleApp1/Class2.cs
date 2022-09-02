using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    public class Calculator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        public static bool SampleMethod(T num1, T num2)
        {
            return false;
        }



    }


    class Demo2
    {
        public static void Main2()
        {
            bool result = Calculator<string>.AreEqual("A", "A");
            if (result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadKey();
        }
    }
}