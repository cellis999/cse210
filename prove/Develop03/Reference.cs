using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Develop03;

public class Reference
{
    public static string Scripture = "Wherefore, brethren, seek not to counsel the Lord, but to take counsel from his hand. For behold, ye yourselves know that he counseleth in wisdom, and in justice, and in great mercy, over all his works.";

    public static void Display(List<string> wordList)
    {
        Console.Clear();
        Console.WriteLine("Jacob 4:10");
        foreach (string word in wordList)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }

    public static string GetScripture()
    {
        return Scripture;
    }
}