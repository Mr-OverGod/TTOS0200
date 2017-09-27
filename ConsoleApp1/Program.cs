using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class Program
    {
        static void Main(string[] args)
        {
                

                // create a one Person object
                Person person = new Person();
                person.FirstName = "Kirsi";
                person.LastName = "Kernel";
                person.Salary = 2000;
                person.Profession = "Teacher";
                Console.WriteLine(person.ToString());

                // create a one Teacher Object
                Teacher teacher = new Teacher();
                teacher.FirstName = "Teppo";
                teacher.LastName = "Konsoli";
                teacher.Profession = "Head of Institute";
                teacher.Salary = 4000;
                teacher.Car = "S6";
            teacher.Bonus = "2000";
                Console.WriteLine(teacher.ToString());


                // do something methods
                person.PersonMethod(); // This method belongs to Person!
                teacher.PersonMethod(); // This method belongs to Person! (derived class can use it!)
                teacher.TeacherMethod(); // This method belongs to Teacher!
            }
        }
    }
    

