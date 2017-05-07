using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_FIle_Exists_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName;
            Console.WriteLine("Enter a filename >>> ");
            fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                Console.WriteLine("File Exists");
                Console.WriteLine("File Was created on" + File.GetCreationTime(fileName));

                Console.WriteLine("File was last accessed" + File.GetLastAccessTime(fileName));

                Console.WriteLine("File was last written to " + File.GetLastWriteTime(fileName));
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

            Console.ReadKey();
        }
    }
}
