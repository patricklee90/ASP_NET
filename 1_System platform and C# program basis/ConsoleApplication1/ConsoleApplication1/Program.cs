using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculating The hypotenuse of pythagorean triangle
            //layman terms: calculate the slope of right triangle
            /*double a, b, c;
            Console.WriteLine("Please enter Adjacent(Horizontal Line) and Opposite(Vertical Line)");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Hypotenuse(Slope Line) is {0}", c);*/

            for (var j = 0; j < 100; j = j + 5)
            {

                var start = j;
                var end = j + 4;

                Console.WriteLine("start: {0}, end: {1}", start, end);
                //Console.WriteLine(j);
                Console.WriteLine("New Line");
            }
        }
    }
}
