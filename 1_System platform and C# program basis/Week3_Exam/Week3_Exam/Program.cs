using System;

namespace Week3_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, gap, multi; 
            double divide;
            Console.WriteLine("Please enter Two Real Numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            gap = a - b;
            multi = a * b;
            divide = a / b;
            Console.WriteLine("Output:{0},{1},{2},{3}", sum, gap, multi, divide);
        }
    }
}
