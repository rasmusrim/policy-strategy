// See https://aka.ms/new-console-template for more information

using Strategy;

var policy = new Policy
{
    Age = 18,
    InterestRate = 0.05f,
    Memberships = new List<string> { "LO" }
};

var engine = new PolicyRuleEngine();

Console.WriteLine("Policy before parsing: " + policy);
engine.ParsePolicy(policy);

Console.WriteLine("Policy after parsing: " + policy);