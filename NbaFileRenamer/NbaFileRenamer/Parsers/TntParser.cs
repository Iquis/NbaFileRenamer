namespace NbaFileRenamer.Parsers;

public class TntParser : Parser
{
    public TntParser() 
        : base(new("^NBA_(?<date>\\d{8})_(?<awayTeam>\\D{3}) @ (?<homeTeam>\\D{3})_.+_TNT(?<extension>\\.\\D{2,3})$"))
    {
    }

    protected override string DateFormat => "yyyyMMdd";

    protected override string GetHomeTeam(string input)
    {
        var homeTeam = base.GetHomeTeam(input);

        return GetTeamFullName(homeTeam);
    }

    protected override string GetAwayTeam(string input)
    {
        var awayTeam = base.GetAwayTeam(input);

        return GetTeamFullName(awayTeam);
    }
}