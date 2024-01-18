namespace Strategy.Strategies;

public class StrategyLogEntry
{
    public string Message { get; set; }
    public Type Type { get; set; }
}

public enum Type
{
    Message,
    Warning,
    Error
}
