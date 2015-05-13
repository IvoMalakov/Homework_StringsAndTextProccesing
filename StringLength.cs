using System;

public class StringLength
{
    public static void Main()
    {

        Console.WriteLine("Enter your input string: ");
        string input = Console.ReadLine();

        string output = String.Empty;
        int fixedLength = 20;

        if (input.Length == fixedLength)
        {
            output = input;
        }

        else if (input.Length > fixedLength)
        {
            output = input.Remove(fixedLength, input.Length - fixedLength);
        }

        else
        {
            output = input + new string('*', fixedLength - 1 - input.Length);
        }

        Console.WriteLine();
        Console.WriteLine("Your output string looks like that: ");
        Console.WriteLine();
        Console.WriteLine(output);
    }
}