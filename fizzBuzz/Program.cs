﻿using System;

class Result
{
    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        //initialize for loop
        for(int i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i% 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
        }
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        // Read the input integer
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        // Call the fizzBuzz function with the input
        Result.fizzBuzz(n);
    }
}
