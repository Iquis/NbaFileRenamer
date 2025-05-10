using NbaFileRenamer.Parsers;

namespace NbaFileRenamer;

public class Renammer
{
    private readonly IEnumerable<Parser> _parsers = [new StandardParser()];
    

    public string GetCorrectNaming(string input)
    {
        var correctParser = _parsers.FirstOrDefault(p => p.IsMatching(input));
        if (correctParser == null)
            throw new ArgumentException($"Can't find correct parser for {input}");
        return correctParser.GetCorrectNaming(input);
    }
}