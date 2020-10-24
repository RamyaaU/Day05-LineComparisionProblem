/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day05LineComparisionProblem.exe Program.cs
 *  Execution:   Day05LineComparisionProblem.exe 103
 *  
 *  Purpose: Calculates length
 *
 *  @author  Ramya U
 *  @version 1.0
 *  @since   22-10-2020
 *
 ******************************************************************************/
using System;

namespace Day03LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparision problem!");
            //variables
            int x1, x2;
            int y1, y2;
            Console.WriteLine("Enter the value of x1 and y1 for line1");
            //Convert.ToInt32 is used to convert a value into 32bit specified integer
            //Assigning values for all the co-ordinates x1,y1,x2,y2
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 and y2 for line1");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            //double type to get both fraction and whole values
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The length of the Line is : " + length);
        }
    }
}