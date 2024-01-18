using Strategy.Strategies;

namespace Strategy.Rules;

public interface IRule
{
    public string GetKey();

    List<StrategyLogEntry> ApplyTo(Policy policy);

}
