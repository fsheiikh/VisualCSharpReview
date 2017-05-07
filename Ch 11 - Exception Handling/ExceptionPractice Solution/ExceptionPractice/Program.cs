using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Name: Farhan Sheikh, 4/08/2017
namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int result;
            int zero = 0;

            try
            {
                Write("Enter an integer >> ");
                answer = Convert.ToInt32(ReadLine());
                result = answer / zero;
            }
            catch (FormatException e)
            {
                WriteLine("You did not enter an integer");
            }
            catch (DivideByZeroException e)
            {
                WriteLine("This is not your fault.");
                WriteLine("You entered the integer correctly.");
                WriteLine("The program divides by zero.");
            }

            WriteLine("The answer is " + answer);
            Console.ReadKey();
        }
    }
}
