using AgileDeadTrees.Domain.Contracts;

namespace AgileDeadTrees.Integration;

public sealed class IntegrationService
{
    private readonly IPrinterClient _printerClient;

    public IntegrationService(IPrinterClient printerClient)
    {
        _printerClient = printerClient;
    }

    public Task<PrintReceipt> DispatchAsync(PrintOrder order, CancellationToken cancellationToken)
        => _printerClient.SendAsync(order, cancellationToken);
}
