using NbaFileRenamer.Parsers;

namespace NbaFileRenamer.Tests;

public class StandardParserTests
{
    [Fact]
    public void Should_Match_CorrectInput()
    {
        var standardParser = new StandardParser();
        var input = "Golden State Warriors - Minnesota Timberwolves 08.05.2025.mkv";

        var result = standardParser.IsMatching(input);
        
        Assert.True(result);
    }
    
    [Fact]
    public void Should_Not_Match_IncorrectInput()
    {
        var standardParser = new StandardParser();
        var input = "";

        var result = standardParser.IsMatching(input);
        
        Assert.False(result);
    }
    
    [Theory]
    [InlineData("Golden State Warriors - Minnesota Timberwolves 08.05.2025.mkv",
        "2025-05-08 Golden State Warriors at Minnesota Timberwolves.mkv")]
    public void Should_Return_CorrectNaming(string input, string expected)
    {
        var standardParser = new StandardParser();

        var result = standardParser.GetCorrectNaming(input);
        
        Assert.Equal(expected, result);
    }
    
}