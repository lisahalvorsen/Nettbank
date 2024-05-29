namespace Nettbank;

public class BankAccount
{
    public string Name { get; set; }
    public int Balance { get; set; }

    public BankAccount(string name, int balance)
    {
        Name = name;
        Balance = balance;
    }

    public void CheckBalance()
    {
       Console.WriteLine($"Du har {Balance} kr på konto"); 
    }

    public void DepositMoney()
    {
        Console.WriteLine("Hvor mye vil du sette inn på kontoen?");
        int depositMoney = int.Parse(Console.ReadLine());
        Balance += depositMoney;
        Console.WriteLine($"Du har nå satt inn {depositMoney} kr på konto");
    }

    public void TransferMoney()
    {
        Console.WriteLine("Hvor mye vil du overføre til den andre kontoen din?");
        int transferMoney = int.Parse(Console.ReadLine());

        if (transferMoney > Balance)
        {
            Console.WriteLine("Du har ikke nok penger på konto til å overføre dette beløpet :( Prøv på nytt!");
        }
        else
        { 
            Balance -= transferMoney;
            Console.WriteLine($"Du har nå overført {transferMoney} kr til den andre kontoen din");   
        }
    }
}
