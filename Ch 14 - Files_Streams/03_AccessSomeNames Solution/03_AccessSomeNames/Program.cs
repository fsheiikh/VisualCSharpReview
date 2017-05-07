using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_AccessSomeNames
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("Names.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            //Declare a constant named END that represents an input value that allows the user to exit the program. Then declare other variables that the program will use.
            const int END = 999;
            int count = 0;
            int num;
            int size;
            string name;


            //Read a line from the input file. While names are available, continue to read and count them. Then compute the size of each name by dividing the file length by the number of strings stored in it.
            name = reader.ReadLine();
            while (name != null)
            {
                count++;
                name = reader.ReadLine();
            }
            size = (int)file.Length / count;

            //Prompt the user for the number of the first record to read, and read the value from the Console. 
            Console.WriteLine("With which number do you want to start? >>");
            num = Convert.ToInt32(Console.ReadLine());

            //Start a loop that continues as long as the user does not enter the sentinel END value. Within the loop, display the user’s number, and then use the Seek() method to position the file pointer at the correct file location.Because users enter numbers starting with 1 and file positions start with 0, you calculate the file position by first subtracting 1 from the user’s entry.The calculated record number is then multiplied by the size of
            //each name in the file. For example, if each name is 10 bytes long, then the calculated starting position should be 0, 10, 20, 30, or some other multiple of the name size.
            while (num != END)
            {
                Console.WriteLine("Starting with name" + num + ": ");
                file.Seek((num - 1) * size, SeekOrigin.Begin);

                //Read and write the name at the calculated location. Then, in a nested loop, read and write all the remaining names until the end of the file.
                name = reader.ReadLine();
                Console.WriteLine(" " + name);
                while (name != null)
                {
                    name = reader.ReadLine();
                    Console.WriteLine(" " + name);
                }

                //Finally, prompt the user for the next starting value for a new list, inform the user how to quit the application, and accept the next input value. Add a closing brace for the outer while loop.
                Console.WriteLine("With which number do you want to start");
                Console.WriteLine(" (Enter " + END + " to quit) >> ");
                num = Convert.ToInt32(Console.ReadLine());
            }



            reader.Close();
            file.Close();

            Console.WriteLine("File CLosed");

            Console.ReadKey(); 
        }
    }
}
