namespace Strategy.Strategies;

public class StrategyFactory
{
    static public IStrategy GetStrategyFor(Policy policy)
    {
        var strategies = GetAll().Where(strategy => strategy.AppliesTo(policy)).ToList();

        if (strategies.Count == 0)
        {
            throw new InvalidDataException("No strategy found for policy " + policy.Id);
        }

        if (strategies.Count > 1)
        {
            throw new InvalidDataException("Multiple strategy found for policy " + policy.Id);
        }

        return strategies.Single();
    }

    static private List<IStrategy> GetAll()
    {
        return new List<IStrategy> { new LoMemberStrategy() };
    }
}
