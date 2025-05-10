using NbaFileRenamer;
using System.Windows;
using TextCopy;

var nbaFileRenamer = new Renammer();

Process();

void Process()
{
    while (true)
    {
        Console.WriteLine("NBA File Name: ");
        var fileName = Console.ReadLine();

        if (!string.IsNullOrEmpty(fileName))
        {
            var result = nbaFileRenamer.GetCorrectNaming(fileName);
            Console.WriteLine(result);
            ClipboardService.SetText(result);
            continue;
        }

        break;
    }
}

