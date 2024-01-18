namespace Strategy.Strategies;

public class StrategyLogEntry
{
    public required string RuleId { get; set; }
    public required string Message { get; set; }
    public Type Type { get; set; }
}

public enum Type
{
    Message,
    Warning,
    Error
}
