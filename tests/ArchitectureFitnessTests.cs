using AgileDeadTrees.Domain.Contracts;
using NetArchTest.Rules;
using Xunit;

namespace AgileDeadTrees.Tests;

public class ArchitectureFitnessTests
{
    [Fact]
    public void Domain_ShouldNotReferenceInfrastructure()
    {
        var result = Types.InAssembly(typeof(PrintOrder).Assembly)
            .That()
            .ResideInNamespace("AgileDeadTrees.Domain")
            .ShouldNot()
            .HaveDependencyOn("AgileDeadTrees.Integration")
            .GetResult();

        Assert.True(result.IsSuccessful, string.Join(", ", result.FailingTypeNames ?? Array.Empty<string>()));
    }

    [Fact]
    public void Repositories_ShouldImplementAbstractInterface()
    {
        var result = Types.InAssembly(typeof(PrintOrder).Assembly)
            .That()
            .HaveNameEndingWith("Repository")
            .Should()
            .ImplementInterface(typeof(IPrinterClient))
            .GetResult();

        Assert.True(result.IsSuccessful, string.Join(", ", result.FailingTypeNames ?? Array.Empty<string>()));
    }
}
