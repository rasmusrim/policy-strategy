namespace Strategy;

public class Policy
{
    public List<string> Memberships { get; set; }
    public int Age { get; set; }
    public float InterestRate { get; set; }
    public bool ShouldSendReportToLaborUnion { get; set; } = false;
    public required int Id { get; set; }
}
