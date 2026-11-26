namespace AgileDeadTrees.Integration.Spreadsheets;

public sealed class AuthorCsvStrategy : ISpreadsheetValidationStrategy
{
    public ParsedSpreadsheet ValidateAndParse(Stream file)
    {
        using var reader = new StreamReader(file);
        var rows = 0;
        while (reader.ReadLine() is { } line)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                rows++;
            }
        }
        return new ParsedSpreadsheet(rows, Array.Empty<string>());
    }
}
