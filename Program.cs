using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance";
            /*Person person = new Person();
            person.Name = "Mika";
            person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 35;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Students students = new Students();
            students.Name = "Sara";
            students.Age = 19;
            students.StudentId = "10506";
            students.Email = "sara1234@amikom.ac.id";
            students.GetNameAndAge();*/

            Person person = new Person("Mika", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAndAge();

            Students students = new Students("Sara", 19, "10506", "sara1234@amikom.ac.id");
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
