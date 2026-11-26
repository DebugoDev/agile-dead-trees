using System.Xml.Linq;
using AgileDeadTrees.Domain.Contracts;

namespace AgileDeadTrees.Integration.Legacy;

public static class LegacyTranslator
{
    public static string ToXml(PrintOrder order) => new XElement("OrdemDeImpressao",
        new XAttribute("id", order.Id),
        new XElement("Titulo", order.BookTitle),
        new XElement("Exemplares", order.Copies)).ToString();
}
