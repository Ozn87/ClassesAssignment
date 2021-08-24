using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Activity
{
    public class Student
    {
        public string Name;
        public string Major;
        Subject SemesterSubj = new Subject();

        public void AddSubjects(params string[] subjects)
        {
            SemesterSubj.Subjects = subjects;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Stundet name: {0}", Name);
            Console.WriteLine("Major for the Student: {0}", Major);
            Console.WriteLine("The classes for this term are:");
            SemesterSubj.Term1();
        }



    }
}
