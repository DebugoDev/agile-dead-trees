namespace AgileDeadTrees.Integration.Spreadsheets;

public sealed class StockExcelStrategy : ISpreadsheetValidationStrategy
{
    public ParsedSpreadsheet ValidateAndParse(Stream file)
    {
        var errors = file.Length == 0
            ? new[] { "Planilha de estoque vazia" }
            : Array.Empty<string>();
        return new ParsedSpreadsheet(0, errors);
    }
}
