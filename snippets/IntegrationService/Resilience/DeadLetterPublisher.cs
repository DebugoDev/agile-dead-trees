using AgileDeadTrees.Domain.Contracts;

namespace AgileDeadTrees.Integration.Resilience;

public sealed class DeadLetterPublisher
{
    public Task PublishAsync(PrintOrder order, string reason, CancellationToken cancellationToken)
        => Task.CompletedTask;
}
