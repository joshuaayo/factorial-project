using System;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //factorial 

            /*Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
                * For example, if the user enters 5, 
             
             * * the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120*/
            int sum = 1;

            Console.Write("Enter integer: ");

            int input; // declare a variable called input
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(sum *=i);
            }

            Console.ReadLine();
            
        }
    }
}
