using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzz
    {
        //Write a program that prints the numbers from 1 to 100. 
        //But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
        //For numbers which are multiples of both three and five print “FizzBuzz”

        [Test]
        public void StandardFizzBuzz()
        {
            var stopwatch = Stopwatch.StartNew();
            var sbuilder = new StringBuilder();
            for (var x = 1; x<=100; x++)
            {
                if(x%(3*5)==0)
                {
                    sbuilder.AppendLine("FizzBuzz");
                }
                else if(x%5==0)
                {
                    sbuilder.AppendLine("Buzz");
                }
                else if(x%3==0)
                {
                    sbuilder.AppendLine("Fizz");
                }
                else
                {
                    sbuilder.AppendLine(x.ToString());
                }
            }
            Console.WriteLine(sbuilder.ToString());
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed {0}ms", stopwatch.ElapsedMilliseconds);
        }

        [Test]
        public void ShrunkenFizzBuzz(){
            var stopwatch = Stopwatch.StartNew();
            for(var x = 1; x <= 100; x++)
            {
                var output = "";
                if (x%3 == 0) output += "Fizz";
                if (x%5 == 0) output += "Buzz";
                if (output == "") output = x.ToString();
                Console.WriteLine(output);
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed {0}ms", stopwatch.ElapsedMilliseconds);
        }

    }
}
