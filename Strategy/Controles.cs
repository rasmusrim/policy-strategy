using Strategy.Strategies;

namespace Strategy;

public class Controles
{
    public Action<string> Stop { get; set; }
    public Action<IStrategy> HandoverToDifferentStrategy { get; set; }
    public Action SkipToEnd { get; set; }
    
}
