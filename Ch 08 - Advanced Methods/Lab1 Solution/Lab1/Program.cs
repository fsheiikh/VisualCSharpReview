using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //Farhan Sheikh 04/01/17
    class Median
    {
        static void Main(string[] args)
        {
            int numberOfGrades; //initializ the total number of grades
            double[] gradesArray; //the srray that holds the gardes
            double median; //median value to be detremined

            getAllGrades(out numberOfGrades, out gradesArray);

            if (numberOfGrades > 0)
            {
                populateArray(ref gradesArray);
                Array.Sort(gradesArray);

                getMedian(gradesArray, out median);

                Console.WriteLine("The Median grade is {0}", median);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Not enough grades...");
                Console.ReadKey();

            }
        }

        static void getAllGrades(out int numberOfGrades, out double[] gradesArray)//takes in initialzied variables and gives them values
        {
            Console.WriteLine("How many total grades are there?");

            while (!(int.TryParse(Console.ReadLine(), out numberOfGrades)))//trap loop to make sure we get an integer value for number of grades
            {
                Console.WriteLine("Please Enter a Valid Number...");
            }

            gradesArray = new double[numberOfGrades]; //once valid number of grades is set, we set our array to hold that number


        }

        static void populateArray(ref double[] gradesArray)//get the array with no values assigned to each index ... yet
        {
            int count = 0; //represents the frist index in the array, i.e. 0

            while (count < gradesArray.Length) //while the index is still within the bounds of the array 
            {
                double grade;

                Console.WriteLine("Enter grade number {0} : ", count + 1); //count + 1 = the number of the grade, i.e. array[0] is the 1st element in the array

                if (double.TryParse(Console.ReadLine(), out grade))//checks to see if the grade entered is valid and then assigns it to the garde varibale
                {
                    gradesArray[count] = grade;//gradesArray[index] = the grade just entered
                    count += 1; //interate count 
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please enter a valid grade");
                }

            } 

            
        }

        static void getMedian(double[] gradesArray, out double median)//get a copy of the grades array and determine the median
        {
            double halfWayPoint;

            if (gradesArray.Length % 2 == 1) //if there is an odd number of grades
            {
                halfWayPoint = gradesArray.Length / 2; // when odd the length/2 is a double that, when cast to an int, is the middle index (the median). ex. 7/2 = 3.5, (int)3.5 = 3. 3 is the index of the median
                median = gradesArray[(int)halfWayPoint];
            }
            else
            {
                halfWayPoint = gradesArray.Length / 2;
                median = (double)((gradesArray[(int)halfWayPoint]) + (gradesArray[(int)halfWayPoint - 1])) / 2; //for an even array we take the length/2 to get an index, and then the index before that index and get their average for the median

            }
        }
        
    }
}
