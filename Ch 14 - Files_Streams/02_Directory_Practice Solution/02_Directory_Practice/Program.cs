using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Directory_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName;
            string[] listOfiles;

            Console.WriteLine("Enter a folder >> ");
            //folder muct be in 02_Directory_Practice Solution\02_Directory_Practice\bin\Debug
            directoryName = Console.ReadLine();

            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("Directory exists" +
                                    "And it has the following : ");
                listOfiles = Directory.GetFiles(directoryName);
                for (int i = 0; i < listOfiles.Length; i++)
                {
                    Console.WriteLine("{0}", listOfiles[i]);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist");
                Directory.CreateDirectory("NewFOlder");
            }
            Console.ReadKey();
        }
    }
}
