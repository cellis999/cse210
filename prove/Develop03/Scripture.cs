using System.Security.Cryptography.X509Certificates;
namespace Develop03;
public class Scripture
{
    public static List<string> MakeList(string passage)
    {
        string[] words = passage.Split(" ");
        return new List<string>(words);
    }

    public void Hide(List<string> wordList)
    {
        Random random = new Random();
        int x = 0;
        while (x < 3)
        {
            int randomInt = random.Next(0, wordList.Count);
            if (wordList[randomInt] != "__")
            {
                wordList[randomInt] = "__";
                x++;
            }
        }
    }
}