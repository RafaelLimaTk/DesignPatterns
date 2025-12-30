namespace State;

/// <summary>
/// State
/// </summary>
public abstract class BankAccountState
{
    public BankAccount BankAccount { get; protected set; } = null!;
    public decimal Balance { get; protected set; }

    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
}

/// <summary>
/// Concrete State
/// </summary>
public class GoldState : BankAccountState
{
    public GoldState(decimal balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, deposited " +
            $"{amount} + 10% bonus: {amount / 10}");
        Balance += amount + (amount / 10);
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
        // change state to overdrawn when withdrawn results in less than 0
        Balance -= amount;
        if (Balance < 1000 && Balance >= 0)
        {
            // change state to regular
            BankAccount.State = new RegularState(Balance, BankAccount);
        }
        else if (Balance < 0)
        {
            // change state to overdrawn
            BankAccount.State = new OverdrawnState(Balance, BankAccount);
        }
    }
}

/// <summary>
/// Concrete State
/// </summary>
public class RegularState : BankAccountState
{
    public RegularState(decimal balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, deposited {amount}");
        Balance += amount;
        if (Balance >= 1000)
        {
            // change state to gold
            BankAccount.State = new GoldState(Balance, BankAccount);
        }
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
        Balance -= amount;
        if (Balance < 0)
        {
            // change state to overdrawn
            BankAccount.State = new OverdrawnState(Balance, BankAccount);
        }
    }
}

/// <summary>
/// Concrete State
/// </summary>
public class OverdrawnState : BankAccountState
{
    public OverdrawnState(decimal balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, deposited {amount}");
        Balance += amount;
        if (Balance >= 0)
        {
            // change state to regular
            BankAccount.State = new RegularState(Balance, BankAccount);
        }
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"In {GetType()}, connot withdraw, balance {Balance}");
    }
}

/// <summary>
/// Context
/// </summary>
public class BankAccount
{
    private BankAccountState _state;
    public decimal Balance => _state.Balance;

    public BankAccount()
        => _state = new RegularState(200, this);

    public BankAccountState State
    {
        get { return _state; }
        set { _state = value; }
    }

    ///<summary>
    /// Request: Deposit
    ///</summary>
    public void Deposit(decimal amount)
        => _state.Deposit(amount);

    ///<summary>
    /// Request: Withdraw
    /// </summary>
    public void Withdraw(decimal amount)
        => _state.Withdraw(amount);
}