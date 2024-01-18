namespace Strategy.Strategies;

public interface IStrategy
{
    public string GetKey();
    public bool AppliesTo(Policy policy);

    List<StrategyLogEntry> ApplyTo(Policy policy);
}
