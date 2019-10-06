using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Program
    {
        class Student
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }

        static void Main(string[] args)
        {

            Student Nihil = new Student();
            Nihil.Number = 01;
            Nihil.Name = "Nihil";
            Nihil.Surname = "Nia";

            Student Gloria = new Student() { Number = 02, Name = "Gloria", Surname = "Nia" };

            int exampleNum = 02;
            string exampleName = "Gloria";
            string exampleSurname = "AI";

            Student[] studentList = new Student[12];
            studentList[0] = Nihil;
            studentList[1] = Gloria;

            for (int i = 0; i < 10; i++)
            {
                Student newStudent = new Student() { Number = exampleNum + 1, Name = exampleName + exampleNum, Surname = exampleSurname + 1};
                studentList[i + 2] = newStudent;
                exampleNum += 1;
            }

            for (int i = 0; i < studentList.Length; i++)
            {
                Console.WriteLine($"Student number: {studentList[i].Number}, Name: {studentList[i].Name}, Surname: {studentList[i].Surname}");
            }

            Console.Read();
        }
    }
}
