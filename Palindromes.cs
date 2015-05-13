using System;
using System.Collections.Generic;

public class Palindromes
{
    public static void Main()
    {
        Console.WriteLine("Enter your string: ");
        Console.WriteLine();
        string input = Console.ReadLine();

        string[] inputArray = input.Split(new char[] {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromesList = new List<string>();

        for (int i = 0; i < inputArray.Length; i++)
        {
            bool validPalindrome = true;

            for (int j = 0; j < inputArray[i].Length / 2; j++)
            {
                if (inputArray[i][j] != inputArray[i][inputArray[i].Length - 1 - j])
                {
                    validPalindrome = false;
                }
            }

            if (validPalindrome)
            {
                palindromesList.Add(inputArray[i]);
            }

        }

        palindromesList.Sort();

        Console.WriteLine();
        Console.WriteLine("In your text you have following palindromes: ");
        Console.WriteLine();

        for (int i = 0; i < palindromesList.Count - 1; i++)
        {
            Console.Write(palindromesList[i] + ", ");
        }

        Console.WriteLine(palindromesList[palindromesList.Count - 1]);
    }
}