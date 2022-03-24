using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab3
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            //1)
            WriteLine("1)------------------------------------");
            StudentCollection studentCollection = new StudentCollection();
            studentCollection.AddDefaults();
            studentCollection.AddStudents(new Student[] { new Student(new Person("Ihor", "Kolotylo", new DateOnly(1999, 10, 23)), Education.SecondEducation, 202) { Exams = new List<Exam>() { new Exam("Java", 4, new DateOnly(2021, 12, 09)), new Exam("Php", 5, new DateOnly(2022, 2, 12)) }, Tests = new List<Test>() { new Test(), new Test("Computer graphic", false), new Test("Database", true) } }, new Student(new Person("Ivan", "Dmytrenko", new DateOnly(2005, 09, 29)), Education.Master, 205) { Exams = new List<Exam>() { new Exam(), new Exam("Database", 3, new DateOnly(2020, 6, 1)) }, Tests = new List<Test>() { new Test() } } });
            WriteLine(studentCollection);
            WriteLine("----------------------------------------\n");


            //2)
            WriteLine("2)------------------------------------");
            WriteLine("--Sort by surname--\n");
            studentCollection.SortBySurname();
            WriteLine(studentCollection);
            WriteLine("--Sort by date--\n");
            studentCollection.SortByDate();
            WriteLine(studentCollection);
            WriteLine("--Sort by grade--\n");
            studentCollection.SortByGrade();
            WriteLine(studentCollection.ToShortString());
            WriteLine("----------------------------------------\n");

            //3)
            WriteLine("3)------------------------------------");
            WriteLine("--Max average grade--");
            WriteLine(studentCollection.MaxGrade);
            WriteLine("--Students with education Master--");
            foreach(Student stud in studentCollection.TypeEducation)
            {
                WriteLine(stud);
            }
            WriteLine("--Group students with mark--");
            foreach(Student stud in studentCollection.AverageMarkGroup(4.5))
            {
                WriteLine(stud);
            }
            WriteLine("----------------------------------------\n");

            //4)
            WriteLine("4)------------------------------------");
            TestCollections testCollection = new TestCollections(1000000);
            testCollection.TimeFinding(1000000);
            WriteLine("----------------------------------------\n");

        }
    }
}
