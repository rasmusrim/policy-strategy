using Strategy.Strategies;

namespace Strategy;

public class PolicyRuleEngine
{
    public void ParsePolicy(Policy policy)
    {
        var strategies = StrategyFactory.GetStrategiesApplicableTo(policy);

        var log = new List<StrategyLogEntry>();

        foreach (var strategy in strategies)
        {
            var controls = new Controles
            {
                Stop = (ruleId) => throw new Exception(ruleId + " stopped execution"),
                HandoverToDifferentStrategy = (strategy) => throw new NotImplementedException(),
                SkipToEnd = () => throw new NotImplementedException(),
            }; 
            
            var result = strategy.ApplyTo(policy, controls);
             log.AddRange(result);
            
        }


    }

}
