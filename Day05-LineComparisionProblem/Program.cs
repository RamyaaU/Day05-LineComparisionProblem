/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day05LineComparision.exe Day05LineComparision.cs
 *  Execution:    Day05LineComparision.exe 103
 *  
 *  Purpose: Comparision of lines
 *
 *  @author  Ramya U
 *  @version 1.0
 *  @since   21-10-2020
 *
/*******************************************************************************/
using System;

namespace Day03LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Line comparision problem!");
            //Variables
            //Here 4 sets of variables are being used to check the equality of 2 lines
            int x1, x2, y1, y2, x3, y3, x4, y4;
            Console.WriteLine("Enter values x1 and y1 for Line 1");
            ////Convert.ToInt32 is used to convert a value into 32bit specified integer
            //Assigning values for all the co-ordinates x1,y1,x2,y2,x3,y3,x4,y4
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 1");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x1 and y1 for Line 2");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 2");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            double len1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double len2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            //if loop is being used to check the condition whether lines are greater equal or smaller in length
            //CompareTo is used to compare the instance of lenth of line by returning 
            //value of instance to be greater or lesser or equal
            int diffInLength = len1.CompareTo(len2);
            if (diffInLength == 0)
                Console.WriteLine("Lines are equal in length");
            else if (diffInLength > 0)
                Console.WriteLine("Line1 is greater in length than Line2");
            else
                Console.WriteLine("Line1 is smaller in length than Line2");
        }
    }
}