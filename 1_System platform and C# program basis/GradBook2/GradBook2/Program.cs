using System;

namespace GradBook2
{
    public class GradeBook
    {
        public void DisplayMessage(string courseName)
        {
            Console.WriteLine("Welcome to the grade book for \n {0}!",courseName);
        }
    }

    class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook myGradebook = new GradeBook();
            Console.WriteLine("Please enter the course name:");
            string nameofCourse = Console.ReadLine();
            Console.WriteLine();
            myGradebook.DisplayMessage(nameofCourse);
        }
    }
}
