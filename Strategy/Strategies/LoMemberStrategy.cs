﻿namespace Strategy.Strategies;

public class LoMemberStrategy : IStrategy
{

    public bool AppliesTo(Policy policy)
    {
        return policy.Memberships.Contains("LO");
    }

    public List<StrategyLogEntry> Apply(Policy policy, Controles controls)
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

        return log;

    }

}