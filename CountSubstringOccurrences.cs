using System;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        Console.WriteLine("Enter your string: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Enter your substring: ");
        string subString = Console.ReadLine();
        Console.WriteLine();

        int count = CountSubStringsInString(input, subString);
            
        Console.WriteLine("Your substring {0} can be found {1} times in your string ", subString, count);
    }

    private static int CountSubStringsInString(string input, string subString)
    {
        input = input.ToLower();
        subString = subString.ToLower();
        int count = 0;
        int i = 0;

        while ((i = input.IndexOf(subString, i)) != -1)
        {
            i++;
            count++;
        }

        return count;
    }
}