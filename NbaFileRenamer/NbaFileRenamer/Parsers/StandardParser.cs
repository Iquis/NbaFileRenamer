using System.Globalization;

namespace NbaFileRenamer.Parsers;

public class StandardParser : Parser
{

    public StandardParser() 
        : base(new("^(?<awayTeam>.+) - (?<homeTeam>.+) (?<date>\\d{2}\\.\\d{2}\\.\\d{4})(?<extension>\\.\\D{2,3})$"))
    {
    }

    protected override DateTime GetDate(string input)
    {
        var match = Regex.Match(input);
        return DateTime.ParseExact(match.Groups["date"].Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
    }
}