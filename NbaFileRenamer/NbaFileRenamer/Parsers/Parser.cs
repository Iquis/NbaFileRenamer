using System.Globalization;
using System.Text.RegularExpressions;

namespace NbaFileRenamer.Parsers;

public abstract class Parser
{
    private readonly Regex _regex;
    protected abstract string DateFormat { get; } 

    protected Parser(Regex regex)
    {
        _regex = regex;
    }
    
    protected string GetTeamFullName(string input)
    {
        return input switch
        {
            "ATL" => "Atlanta Hawks",
            "BOS" => "Boston Celtics",
            "BKN" => "Brooklyn Nets",
            "CHA" => "Charlotte Hornets",
            "CHI" => "Chicago Bulls",
            "CLE" => "Cleveland Cavaliers",
            "DAL" => "Dallas Mavericks",
            "DEN" => "Denver Nuggets",
            "DET" => "Detroit Pistons",
            "GSW" => "Golden State Warriors",
            "HOU" => "Houston Rockets",
            "IND" => "Indiana Pacers",
            "LAC" => "Los Angeles Clippers",
            "LAL" => "Los Angeles Lakers",
            "MEM" => "Memphis Grizzlies",
            "MIA" => "Miami Heat",
            "MIL" or "MLK" => "Milwaukee Bucks",
            "MIN"  => "Minnesota Timberwolves",
            "NOP" => "New Orleans Pelicans",
            "NYK" => "New York Knicks",
            "OKC" => "Oklahoma City Thunder",
            "ORL" => "Orlando Magic",
            "PHI" => "Philadelphia 76ers",
            "PHX" => "Phoenix Suns",
            "POR" => "Portland Trail Blazers",
            "SAC" => "Sacramento Kings",
            "SAS" => "San Antonio Spurs",
            "TOR" => "Toronto Raptors",
            "UTH" => "Utah Jazz",
            "WAS" => "Washington Wizards",
            _ => throw new ArgumentOutOfRangeException(nameof(input), input, null)
        };
    }

    public string GetCorrectNaming(string input)
    {
        var homeTeam = GetHomeTeam(input);
        var awayTeam = GetAwayTeam(input);
        var date = GetDate(input);
        var fileExtension = GetFileExtension(input);
        return $"{date:yyyy-MM-dd} {awayTeam} at {homeTeam}{fileExtension}";
    }

    public virtual bool IsMatching(string input) => _regex.IsMatch(input);

    protected virtual string GetFileExtension(string input)
    {
        var match = _regex.Match(input);
        return match.Groups["extension"].Value;
    }

    protected virtual string GetHomeTeam(string input)
    {
        var match = _regex.Match(input);
        return match.Groups["homeTeam"].Value;
    }

    protected virtual string GetAwayTeam(string input)
    {
        var match = _regex.Match(input);
        return match.Groups["awayTeam"].Value;
    }

    protected virtual DateTime GetDate(string input)
    {
        var match = _regex.Match(input);
        var value = match.Groups["date"].Value;
        
        return DateTime.ParseExact(value, DateFormat, CultureInfo.InvariantCulture);

    }
}