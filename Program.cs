﻿internal class Program
{
    private static void Main(string[] args)
    {
        // make test scores
        int[] scores = { 50, 66, 90, 81, 77, 45, 0, 100, 99, 74, 85, 82, 23, 43, 11, 15, 98 };

        // print the scores
        foreach (var item in scores)
        {
            Console.WriteLine("One of the scores was {0}", item);
        }

        // pause statement to see the output
        Console.ReadLine();
    }
}