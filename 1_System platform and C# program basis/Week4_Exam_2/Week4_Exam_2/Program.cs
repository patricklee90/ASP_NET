using System;

namespace Week4_Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, count = 0;
            double sum = 0;

            Console.WriteLine("Please enter 10 students score");
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x > 100)
                {
                    Console.WriteLine("Please Enter Again: ");
                    continue;
                }
                else if (x < 0)
                {
                    Console.WriteLine("Input Invalid! Please Enter Again: ");
                    continue;
                }

                sum = sum + x;
                count++;
            }
            while (count < 10);          
            Console.WriteLine("{0}", sum / count);
        }
    }
}
