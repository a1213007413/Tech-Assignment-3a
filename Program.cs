/*
 Author: Wei Ming Guo
 Date: 9/23/2020
 Tech Assignment 3A for ISM 4300
*/

using System;

namespace Tech_Assignment_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input their name
            Console.WriteLine("Please Enter Your Name:");
            try
            {
                string name;
                name = Console.ReadLine();

                Console.WriteLine("Hello {0}", name + "-Go Bucs"); //Display the output..

                Console.WriteLine("Please Enter Your Name to display message...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);

            }
            catch
            {
                Console.WriteLine("Please Enter Your Name to display message...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
