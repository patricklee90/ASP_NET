using System;

namespace Gradebook3
{
    class GradeBook
    {
        private string courseName;

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for {0}", CourseName);
        }
    }

    class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook myGradeName = new GradeBook();
            Console.WriteLine("Coursename is:'{0}'\n",myGradeName.CourseName);
            Console.WriteLine("Please enter the course name:");
            myGradeName.CourseName = Console.ReadLine();
            Console.WriteLine();
            myGradeName.DisplayMessage();
        }
    }

}
