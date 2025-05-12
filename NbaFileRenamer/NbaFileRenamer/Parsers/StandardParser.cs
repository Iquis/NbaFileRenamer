namespace NbaFileRenamer.Parsers;

public class StandardParser : Parser
{

    public StandardParser() 
        : base(new("^(?<awayTeam>.+) - (?<homeTeam>.+) (?<date>\\d{2}\\.\\d{2}\\.\\d{4})(?<extension>\\.\\D{2,3})$"))
    {
    }

    protected override string DateFormat => "dd.MM.yyyy";
}