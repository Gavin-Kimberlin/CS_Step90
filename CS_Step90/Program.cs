using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\r\nPerson 1\r\nHourly Rate?");
            byte person1Rate = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            byte person1Hours = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Person 2\r\nHourly Rate?");
            byte person2Rate = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            byte person2Hours = Convert.ToByte(Console.ReadLine());

            int person1Salary = person1Rate * person1Hours * 52;
            int person2Salary = person2Rate * person2Hours * 52;
            Console.WriteLine("Annual salary of Person 1:\r\n" + person1Salary);
            Console.WriteLine("Annual salary of Person 2:\r\n" + person2Salary);

            bool makesMore = person1Salary > person2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2?\r\n" + makesMore);
            Console.ReadLine();

        }
    }
}
