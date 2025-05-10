namespace NbaFileRenamer.Tests;

public class RenammerTests
{

    [Theory]
    [InlineData("Golden State Warriors - Minnesota Timberwolves 08.05.2025.mkv",
        "2025-05-08 Golden State Warriors at Minnesota Timberwolves.mkv")]
    public void Should_Return_CorrectNaming(string input, string expected)
    {
        var renammer = new Renammer();

        var result = renammer.GetCorrectNaming(input);
        
        Assert.Equal(expected, result);
    }
}