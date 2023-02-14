using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop
{

    internal class Student
    {
        int gpa;

        public int Gpa
        {
            get { return gpa; }
            set
            {
                gpa= value;
            }
        }
        public void PrintGPA()
        {
            Console.WriteLine($"GPA: {gpa}");
        }

        
    }
    internal class Person
    {
        string name;
        int age;

        public string Name
        {
            get { return name; }
            set
            { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new Exception("tuoi khong hop le");
            }
        }
        public void PrintPerson()
        {
            Console.WriteLine($"ten: {name}, tuoi : {age}");
        }
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Student student1 = new Student();
            person1.Name = "lok";
            try
            {
                person1.Name = "Huy";
                person1.Age = -3;
                student1.Gpa = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            person1.PrintPerson();
            student1.PrintGPA();
            Console.ReadLine();

        }
    }
}
