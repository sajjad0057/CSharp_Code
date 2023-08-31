namespace BehavioralDesignPattern.StrategyPattern;

public interface ISalaryCalculator
{
    double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
}

