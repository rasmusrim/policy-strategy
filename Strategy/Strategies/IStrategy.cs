namespace Strategy.Strategies;

public interface IStrategy
{
    public bool AppliesTo(Policy policy);

    List<StrategyLogEntry> Apply(Policy policy, Controles controls);
}
