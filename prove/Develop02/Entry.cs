using System.Net;
using System.Runtime.CompilerServices;
namespace Develop02;
public class Entry
{
    public string Prompt;
    public string Response;
    public DateTime Date;

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}
