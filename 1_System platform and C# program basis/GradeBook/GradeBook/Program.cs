using System;

namespace GradeBook
{
    public class GradeBook
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book!");
        }
    }

    class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook myGradebook = new GradeBook();
            myGradebook.DisplayMessage();
        }
    }
}
