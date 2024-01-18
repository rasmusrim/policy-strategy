namespace Strategy.Strategies;

public class GeneralLaborUnionStrategy : IStrategy
{
    public string GetKey()
    {
        return "general-labor-union";
    }

    public bool AppliesTo(Policy policy)
    {
        return false; // Will only ever be called by a different strategy.
    }

    public List<StrategyLogEntry> ApplyTo(Policy policy)
    {
        policy.ShouldSendReportToLaborUnion = true;
        return new List<StrategyLogEntry>
        {
            new StrategyLogEntry
            {
                RuleId = GetKey(),
                Type = Type.Message,
                Message = "Set should send report to labor union to true."
            }
        };
    }
}
