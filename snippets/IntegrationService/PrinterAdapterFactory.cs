using AgileDeadTrees.Domain.Contracts;
using AgileDeadTrees.Integration.Legacy;

namespace AgileDeadTrees.Integration;

public interface IPrinterClientFactory
{
    IPrinterClient Create(string printerId);
}

public sealed class PrinterAdapterFactory : IPrinterClientFactory
{
    private readonly Func<SerialMainframeAdapter> _serialFactory;
    private readonly Func<OpcUaMainframeAdapter> _opcUaFactory;

    public PrinterAdapterFactory(
        Func<SerialMainframeAdapter> serialFactory,
        Func<OpcUaMainframeAdapter> opcUaFactory)
    {
        _serialFactory = serialFactory;
        _opcUaFactory = opcUaFactory;
    }

    public IPrinterClient Create(string printerId)
        => printerId.StartsWith("SERIAL", StringComparison.OrdinalIgnoreCase)
            ? _serialFactory()
            : _opcUaFactory();
}
