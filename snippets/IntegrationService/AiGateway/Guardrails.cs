using System.Text.RegularExpressions;

namespace AgileDeadTrees.Integration.AiGateway;

public static class Guardrails
{
    private static readonly Regex Cpf = new(@"\b\d{3}\.\d{3}\.\d{3}-\d{2}\b", RegexOptions.Compiled);
    private static readonly Regex Email = new(@"\b[\w.+-]+@[\w-]+\.[\w.-]+\b", RegexOptions.Compiled);

    public static string MaskPii(string input)
        => Email.Replace(Cpf.Replace(input, "[CPF]"), "[EMAIL]");

    public static bool IsAllowed(string prompt)
        => !prompt.Contains("ignore previous instructions", StringComparison.OrdinalIgnoreCase);

    public static bool MatchesSchema(string json)
        => json.Contains("\"answer\"", StringComparison.Ordinal);
}
