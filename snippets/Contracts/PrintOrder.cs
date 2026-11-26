namespace AgileDeadTrees.Domain.Contracts;

public sealed record PrintOrder(Guid Id, string BookTitle, int Copies, string PrinterId);

public sealed record PrintReceipt(Guid OrderId, string Status, DateTimeOffset ProcessedAt);
