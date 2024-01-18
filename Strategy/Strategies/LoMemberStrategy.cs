using Strategy.Rules;

namespace Strategy.Strategies;

public class LoMemberStrategy : IStrategy
{

    public string GetKey()
    {
        return "lo-member";
    }

    public bool AppliesTo(Policy policy)
    {
        return policy.Memberships.Contains("LO");
    }

    public List<StrategyLogEntry> ApplyTo(Policy policy, Controles controls)
    {
        var log = new List<StrategyLogEntry>();
        if (policy.Age > 60)
        {
            policy.InterestRate *= 0.9f;
            log.Add(new StrategyLogEntry { Message = "Holder is older than 60 years, applying 10% discount", Type = Type.Message });
        }
        else
        {
            log.Add(new StrategyLogEntry { Message = "Holder is younger than 60 years, no discount applied", Type = Type.Message });

        }
        
        var rules = new List<IRule> { new Rule1(), new Rule2() };

        foreach (var rule in rules)
        {
            var ruleLogs = rule.ApplyTo(policy);
            log.AddRange(ruleLogs);
        }
        
        return log;

    }

}
