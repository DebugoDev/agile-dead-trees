using Polly;

namespace AgileDeadTrees.Integration.Resilience;

public static class ResiliencePolicies
{
    public static IAsyncPolicy Build() => Policy.WrapAsync(
        Policy.TimeoutAsync(TimeSpan.FromSeconds(2)),
        Policy.Handle<TimeoutException>().WaitAndRetryForeverAsync(attempt =>
            TimeSpan.FromMilliseconds(Math.Min(1000, 50 * Math.Pow(2, attempt)))
            + TimeSpan.FromMilliseconds(Random.Shared.Next(0, 50))),
        Policy.Handle<Exception>().CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));
}
