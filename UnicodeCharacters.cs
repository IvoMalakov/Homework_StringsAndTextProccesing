using System;

public class UnicodeCharacters
{
    public static void Main()
    {
        Console.WriteLine("Enter your string: ");
        string input = Console.ReadLine();

        char[] array = input.ToCharArray();
        int n = array.Length;
        int [] unicodes = new int[n];

        for (int i = 0; i < n; i++)
        {
            unicodes[i] = array[i];
        }

        Console.WriteLine();
        Console.WriteLine("Unicode symbols of your string are : ");
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write("\\u{0:x4}", unicodes[i]);
        }

        Console.WriteLine();
    }
}