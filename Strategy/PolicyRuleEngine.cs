using Strategy.Strategies;

namespace Strategy;

public class PolicyRuleEngine
{
    public List<StrategyLogEntry> ParsePolicy(Policy policy)
    {
        var strategy = StrategyFactory.GetStrategyFor(policy);

        return strategy.ApplyTo(policy);
    }
}
