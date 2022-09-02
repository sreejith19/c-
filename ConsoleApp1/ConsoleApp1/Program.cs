using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public string title;
        public string author;
        public int price;
    }
    internal class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World");
            Book b = new Book();
            b.title = "html";
            b.author = "mark";
            b.price = 1000;
            Console.WriteLine("Title:"+b.title+" Author: "+b.author+" price: "+b.price);
            Console.ReadKey();
        }
    }
}
