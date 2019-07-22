using System;

namespace Week4_Exam
{

    class Program
    {
        static void Main(string[] args)
        {
            int Rounding;
            double input1, input2, input3, sum;

            Console.WriteLine("Please insert 3 floating number within 10");
            input1 = Convert.ToDouble(Console.ReadLine());
            input2 = Convert.ToDouble(Console.ReadLine());
            input3 = Convert.ToDouble(Console.ReadLine());

            sum = input1 + input2 + input3;

            Rounding = Convert.ToInt32(Math.Round(sum, 0));

            Console.WriteLine("");
            Console.WriteLine("Your output is {0}", Rounding);
        }
    }
}
