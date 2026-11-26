namespace AgileDeadTrees.Integration.Spreadsheets;

public sealed record ParsedSpreadsheet(int Rows, IReadOnlyList<string> Errors);

public interface ISpreadsheetValidationStrategy
{
    ParsedSpreadsheet ValidateAndParse(Stream file);
}
