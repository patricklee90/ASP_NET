using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Library.Test
{
    [TestClass]
    public class FizzBuzzerTest
    {

        [TestMethod]
        public void Buzzer_WhenDefault_ReturnsInput()
        {
            int[] input = { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19 };
            for(int i =0; i < input.Length; i++)
            {
                string output = FizzBuzzer.GetValue(input[i]);
                Assert.AreEqual(input[i].ToString(), output);
            }   
        }

        [TestMethod]
        public void Buzzer_WhenDiv3_ReturnsFizz()
        {
            int[] input = { 3, 6, 9, 12, 18 };
            for (int i = 0; i < input.Length; i++)
            {
                string output = FizzBuzzer.GetValue(input[i]);
                Assert.AreEqual("Fizz", output);
            }
        }

        [TestMethod]
        public void Buzzer_WhenDiv5_ReturnsBuzz()
        {
            int[] input = { 5, 10, 20 };
            for (int i = 0; i < input.Length; i++)
            {
                string output = FizzBuzzer.GetValue(input[i]);
                Assert.AreEqual("Buzz", output);
            }
        }

        [TestMethod]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz()
        {
            int[] input = { 15 };
            for (int i = 0; i < input.Length; i++)
            {
                string output = FizzBuzzer.GetValue(input[i]);
                Assert.AreEqual("FizzBuzz", output);
            }
        }
    }
}
