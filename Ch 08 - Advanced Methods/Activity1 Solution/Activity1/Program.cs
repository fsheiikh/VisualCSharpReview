using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Activity1
{
    class SwapProgram
    {
        static void Main(string[] args)
        {
            int first = 34, second = 712;

            Console.WriteLine(String.Format("Before Swap [First: {0} | Second: {1}]", first.ToString(), second.ToString()));

            Swap(ref first, ref second);

            Console.WriteLine(String.Format("After Swap [First: {0} | Second: {1}]", first.ToString(), second.ToString()));

            Console.ReadKey();
        }

        static void Swap(ref int one, ref int two)
        {
            int temp = one;
            one = two;
            two = temp;
        }
    }
}
