namespace NbaFileRenamer;

public class Renammer
{
    public string GetTeamFullName(string input)
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
}