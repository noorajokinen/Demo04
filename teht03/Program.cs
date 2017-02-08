using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee:");
            Employee employee = new Employee();
            employee.Name = "Sanna Ammattilainen";
            employee.Profession = "Sihteeri";
            employee.Salary = 2000;
            Console.WriteLine(employee.ToString());

            Console.WriteLine("Boss:");
            Boss boss = new Boss();
            boss.Name = "Piia Pomo";
            boss.Profession = "Tiiminjohtaja";
            boss.Salary = 5000;
            boss.Bonus = 400;
            boss.Car = "Audi";
            Console.WriteLine(boss.ToString());

        }
    }
}
