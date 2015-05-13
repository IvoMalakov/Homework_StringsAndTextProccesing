using System;
using System.Text;

public class TextFilter
{
    public static void Main()
    {
        Console.WriteLine("Enter words in your ban list separeted by \", \":  ");
        string[] banned = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine();
        Console.WriteLine("Enter your text here: ");
        string text = Console.ReadLine();

        string[] asterix = new string[banned.Length];
        StringBuilder sb = new StringBuilder(text);

        for (int i = 0; i < banned.Length; i++)
        {
            asterix[i] = new String('*', banned[i].Length);
            sb.Replace(banned[i], asterix[i]);

        }

        Console.WriteLine();
        Console.WriteLine("Your new banned text looks like that: ");
        Console.WriteLine();
        Console.WriteLine(sb);
    }
}