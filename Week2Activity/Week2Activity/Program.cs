using System;

namespace Week2Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            var student2 = new Student();
            student1.Name = "Osiris loera";
            student1.Major = "Web development";
            student1.AddSubjects("English", "Intro to C#", "OOP", "Javascript");
            student1.PrintStudentInfo();


            Console.ReadLine();
            student2.Name = "Mat";
            student2.Major = "Economy";
            student2.AddSubjects("intro to economy");
            student2.PrintStudentInfo();
        }
    }
}
