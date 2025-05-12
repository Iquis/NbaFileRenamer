using NbaFileRenamer.Parsers;

namespace NbaFileRenamer.Tests;

public class ParserTests
{

    [Fact]
    public void StandardParser_Should_Match_CorrectInput()
    {
        Process_Should_Match_CorrectInput(new StandardParser(),
            "Golden State Warriors - Minnesota Timberwolves 08.05.2025.mkv");

        Process_Should_Match_CorrectInput(new TntParser(), "NBA_20250506_GSW @ MIN_1080p60_TNT.mkv");
    }

    [Fact]
    public void Should_Not_Match_IncorrectInput()
    {
        Process_Should_Not_Match_IncorrectInput(new StandardParser(), "");
        Process_Should_Not_Match_IncorrectInput(new TntParser(), "");
    }

    [Fact]
    public void Should_Return_CorrectNaming()
    {
        Process_Should_Return_CorrectNaming(new StandardParser(),
            "Golden State Warriors - Minnesota Timberwolves 08.05.2025.mkv",
            "2025-05-08 Golden State Warriors at Minnesota Timberwolves.mkv");

        Process_Should_Return_CorrectNaming(new TntParser(), 
            "NBA_20250506_GSW @ MIN_1080p60_TNT.mkv",
            "2025-05-06 Golden State Warriors at Minnesota Timberwolves.mkv");
    }

    private void Process_Should_Match_CorrectInput(Parser parser, string input)
    {
        var result = parser.IsMatching(input);
        
        Assert.True(result);
    }

    private void Process_Should_Not_Match_IncorrectInput(Parser parser, string input)
    {
        var result = parser.IsMatching(input);
        
        Assert.False(result);
    }
    
    private void Process_Should_Return_CorrectNaming(Parser parser, string input, string expected)
    {
        var result = parser.GetCorrectNaming(input);
        
        Assert.Equal(expected, result);
    }
}