using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Exercise7
{
    internal class Program
    {


        public class Employees
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Salary { get; set; }

        }


        static void Main(string[] args)
        {
            List<Employees> userlist = new List<Employees>
             {
                new Employees { FName="John", LName= "Doe", Salary = 1230 },
                new Employees { FName="Lucy", LName= "Novak", Salary = 670 },
                new Employees { FName="Ben", LName= "Walter", Salary = 2050 },
                new Employees { FName="Robin", LName= "Brown", Salary = 2300 },
                new Employees { FName="Amy", LName= "Doe", Salary = 1250 },
                new Employees { FName="John", LName= "Draker", Salary = 1190},
                new Employees { FName="Janet", LName= "Doe", Salary = 980 },
                new Employees { FName="Albert", LName= "Novak", Salary = 1930 },


            };
            IEnumerable<Employees> result = (from Employee in userlist
                                             orderby Employee.LName ascending, Employee.Salary ascending
                                             select Employee);


            result.ToList().ForEach(Employee => Console.WriteLine($"{Employee.LName}, {Employee.Salary}"));
            //Console.ReadKey();

            IEnumerable<Employees> result1 = (from Employee1 in userlist
                                              where Employee1.Salary > 1500
                                              select Employee1);


            result1.ToList().ForEach(Employee1 => Console.WriteLine($"Salary: {Employee1.Salary}"));
            Console.ReadKey();
        }
    }
}