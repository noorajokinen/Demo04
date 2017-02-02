using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Person person = new Person(); Tätä ei yleensä tehdä, koska ajatuksena juuri oli luoda aliluokkia. Harvemmin käytetään pääluokkaa oliona

            //luodaan teacher olio
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kirsi";
            teacher.LastName = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "+345000";
            teacher.Room = "D345";
            Console.WriteLine(teacher.ToString());


            Student student = new Student("Matti", "Mattinen", "M93");
            student.Address = "Kirsikkakuja 18";
            student.Age = 25;
            student.PhoneNumber = "+54 0387";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

        }
    }
}
