using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
    public class Company
    {
        private List<Employee> listEmployees;
        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { Id = 1, Name = "Mark", Gender = "Male", Age = 20 });
            listEmployees.Add(new Employee() { Id = 2, Name = "Smith", Gender = "Male", Age = 30 });
            listEmployees.Add(new Employee() { Id = 3, Name = "Paul", Gender = "Male", Age = 25 });
            listEmployees.Add(new Employee() { Id = 4, Name = "Stacy", Gender = "Male", Age = 22 });
            listEmployees.Add(new Employee() { Id = 5, Name = "Watson", Gender = "Female", Age = 23 });
        }
        public string this[int id]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.Id == id).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.Id == id).Name = value;
            }
        }
        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.Gender == gender).ToString();
            }
            set
            {
                foreach (Employee emp in listEmployees)
                {
                    if (emp.Gender == gender)
                    {
                        emp.Gender = value;
                    }
                }
            }
        }
    }
    internal class Class1
    {
        public static void Main2()
        {
            Company c = new Company();

            Console.WriteLine("Employee Name : {0}", c[1]);
            Console.WriteLine("Employee Name : {0}", c[2]);
            Console.WriteLine("Employee Name : {0}", c[5]);

            c[1] = "Mark 2";
            c[2] = "Smith 2";
            c[5] = "Watson 2";

            Console.WriteLine("Employee Name : {0}", c[1]);
            Console.WriteLine("Employee Name : {0}", c[2]);
            Console.WriteLine("Employee Name : {0}", c[5]);

            Console.WriteLine("Total Male Employee: {0}", c["Male"]);
            Console.WriteLine("Total Female Employee: {0}", c["Female"]);

            c["Male"] = "Female";
            c["Female"] = "Male";

            Console.WriteLine("Total Male Employee: {0}", c["Male"]);
            Console.WriteLine("Total Female Employee: {0}", c["Female"]);

            Console.ReadKey();
        }
    }
}
