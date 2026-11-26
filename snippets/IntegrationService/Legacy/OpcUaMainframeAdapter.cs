using AgileDeadTrees.Domain.Contracts;

namespace AgileDeadTrees.Integration.Legacy;

public interface IOpcUaGateway
{
    Task PublishAsync(string nodeId, string payload, CancellationToken cancellationToken);
}

public sealed class OpcUaMainframeAdapter : IPrinterClient
{
    private readonly IOpcUaGateway _gateway;

    public OpcUaMainframeAdapter(IOpcUaGateway gateway) => _gateway = gateway;

    public async Task<PrintReceipt> SendAsync(PrintOrder order, CancellationToken cancellationToken)
    {
        await _gateway.PublishAsync("ns=2;s=PrintOrders", LegacyTranslator.ToXml(order), cancellationToken);
        return new PrintReceipt(order.Id, "SENT", DateTimeOffset.UtcNow);
    }
}
