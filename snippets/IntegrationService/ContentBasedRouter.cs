using AgileDeadTrees.Domain.Contracts;

namespace AgileDeadTrees.Integration;

public sealed class ContentBasedRouter
{
    public string Route(PrintOrder order)
        => order.Copies > 0 ? "print.orders" : "print.invalid";
}
