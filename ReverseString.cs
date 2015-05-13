using System;
using System.Text;

public class ReverseString
{
    public static void Main()
    {
        Console.WriteLine("Enter your string: ");
        string inputString = Console.ReadLine();

        string reversedString = StringReverse(inputString);

        Console.WriteLine("Your reversed string looks like that: ");
        Console.WriteLine(reversedString);
    }

    private static string StringReverse(string inputString)
    {
        StringBuilder stringBuild = new StringBuilder();

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            stringBuild.Append(inputString[i]);
        }

        return stringBuild.ToString();
    }
}