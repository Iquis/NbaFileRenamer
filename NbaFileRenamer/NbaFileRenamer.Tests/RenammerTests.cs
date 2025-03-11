namespace NbaFileRenamer.Tests;

public class RenammerTests
{
    [Theory]
    [InlineData("ATL","Atlanta Hawks")]
    [InlineData("BOS","Boston Celtics")]
    [InlineData("BKN","Brooklyn Nets")]
    [InlineData("CHA","Charlotte Hornets")]
    [InlineData("CHI","Chicago Bulls")]
    [InlineData("CLE","Cleveland Cavaliers")]
    [InlineData("DAL","Dallas Mavericks")]
    [InlineData("DEN","Denver Nuggets")]
    [InlineData("DET","Detroit Pistons")]
    [InlineData("GSW","Golden State Warriors")]
    [InlineData("HOU","Houston Rockets")]
    [InlineData("IND","Indiana Pacers")]
    [InlineData("LAC","Los Angeles Clippers")]
    [InlineData("LAL","Los Angeles Lakers")]
    [InlineData("MEM","Memphis Grizzlies")]
    [InlineData("MIA","Miami Heat")]
    [InlineData("MIL","Milwaukee Bucks")][InlineData("MLK","Milwaukee Bucks")]
    [InlineData("MIN","Minnesota Timberwolves")]
    [InlineData("NOP","New Orleans Pelicans")]
    [InlineData("NYK","New York Knicks")]
    [InlineData("OKC","Oklahoma City Thunder")]
    [InlineData("ORL","Orlando Magic")]
    [InlineData("PHI","Philadelphia 76ers")]
    [InlineData("PHX","Phoenix Suns")]
    [InlineData("POR","Portland Trail Blazers")]
    [InlineData("SAC","Sacramento Kings")]
    [InlineData("SAS","San Antonio Spurs")]
    [InlineData("TOR","Toronto Raptors")]
    [InlineData("UTH","Utah Jazz")]
    [InlineData("WAS","Washington Wizards")]
    public void Should_Return_FullTeamName(string input, string expected)
    {
        var renammer = new Renammer();
        
        var result = renammer.GetTeamFullName(input);
        Assert.Equal(expected, result);
    }
}