namespace AgileDeadTrees.Domain.Contracts;

public interface IPrinterClient
{
    Task<PrintReceipt> SendAsync(PrintOrder order, CancellationToken cancellationToken);
}
