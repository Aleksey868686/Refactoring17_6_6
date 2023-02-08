namespace Refactoring17_6_6;

internal class Program
{
    static void Main(string[] args)
    {
        IAccount regAccount = new RegularAccount(900);
        IAccount salAccount = new SalaryAccount(1500);
        Calculator.CalculateAccountInterest(regAccount);
        Calculator.CalculateAccountInterest(salAccount);
    }
}

public interface IAccount
{
    string Type { get; set; }
    double Balance { get; set; }
    double Interest { get; set; }

    void CalculateInterest();
}

public class RegularAccount : IAccount
{
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }

    public RegularAccount(double balance)
    {
        Type = "Обычный";
        this.Balance = balance;
    }

    public void CalculateInterest()
    {

        // расчет процентной ставки обычного аккаунта по правилам банка
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;

        if (Balance < 50000)
            Interest -= Balance * 0.4;
    }
}

public class SalaryAccount : IAccount
{
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }

    public SalaryAccount(double balance)
    {
        Type = "Зарплатный";
        this.Balance = balance;
    }

    public void CalculateInterest()
    {

        // расчет процентной ставки зарплатного аккаунта по правилам банка
        Interest = Balance * 0.5;
    }
}

public static class Calculator
{
    public static void CalculateAccountInterest(IAccount account)
    {
        account.CalculateInterest();
    }
}