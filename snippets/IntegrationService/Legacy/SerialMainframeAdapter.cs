using System.IO.Ports;
using System.Text;
using AgileDeadTrees.Domain.Contracts;

namespace AgileDeadTrees.Integration.Legacy;

public sealed class SerialMainframeAdapter : IPrinterClient
{
    private readonly SerialPort _port;

    public SerialMainframeAdapter(SerialPort port) => _port = port;

    public async Task<PrintReceipt> SendAsync(PrintOrder order, CancellationToken cancellationToken)
    {
        var payload = Encoding.ASCII.GetBytes(LegacyTranslator.ToXml(order));
        await _port.BaseStream.WriteAsync(payload, cancellationToken);
        return new PrintReceipt(order.Id, "SENT", DateTimeOffset.UtcNow);
    }
}
