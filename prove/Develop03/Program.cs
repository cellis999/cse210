using System;
using System.Net.Quic;
namespace Develop03;

public class Program
{
    static void Main(string[] args)
    {
        Reference.Display(Scripture.MakeList(Reference.GetScripture()));

        List<string> wordList = Scripture.MakeList(Reference.GetScripture());
        Word word = new Word(wordList);

        while (true)
        {
            Console.WriteLine("Press Enter to hide words, type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input == "")
            {
                word.ReplaceRandomWords();
                Reference.Display(word.WordList);

                if (word.AreAllWordsHidden())
                {
                    break;
                }
            }
            else if (input == "quit")
            {
                break;
            }
        }
    }
}
