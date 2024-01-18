using Strategy.Strategies;
using Type = Strategy.Strategies.Type;

namespace Strategy.Rules;

public class Rule2 : IRule
{

    public string GetKey()
    {
        return "rule2";
    }

    public List<StrategyLogEntry> ApplyTo(Policy policy)
    {
        Console.WriteLine("Doing stuff to policy which can be used by multiple strategies.");

        return new List<StrategyLogEntry>
        {
            new StrategyLogEntry
            {
                Message = "Carried out rule " + GetKey(), Type = Type.Message
            }
        };
    }
}
