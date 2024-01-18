namespace Strategy.Strategies;

public class StrategyFactory
{
    static public List<IStrategy> GetStrategiesApplicableTo(Policy policy)
    {
        return GetAll().Where(strategy => strategy.AppliesTo(policy)).ToList();
    }

    static private List<IStrategy> GetAll()
    {
        return new List<IStrategy> { new LoMemberStrategy() };
    }
}

