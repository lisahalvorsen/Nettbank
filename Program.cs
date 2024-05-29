namespace Nettbank;

class Program
{
    static void Main(string[] args)
    {
        /* Nettbanken (Objekt, input/output)
           Du skal lage en konsollapp som oppfører seg som en nettbank.
           Man skal kunne se hvor mye man har på konto, sette inn penger og
           overføre penger til en annen konto
         */

        var bankAccount1 = new BankAccount("Main account", 0);

        Console.WriteLine("Hei og velkommen til Cool Bank B) Hva vil du gjøre i dag?");
        
        bool loggedIn = true;

        while (loggedIn)
        {
            Console.WriteLine("1. Sjekke saldo");
            Console.WriteLine("2. Sette inn penger");
            Console.WriteLine("3. Overføre penger til en annen konto");
            Console.WriteLine("4. Logg ut av nettbanken");
            var chooseAnAction = Console.ReadLine();

            switch (chooseAnAction)
            {
                case "1":
                    bankAccount1.CheckBalance();
                    break;
                case "2":
                    bankAccount1.DepositMoney();
                    break;
                case "3":
                    bankAccount1.TransferMoney();
                    break;
                case "4":
                    Console.WriteLine("Ha en fin dag :)");
                    loggedIn = false;
                    break;
            }
        }
    }
}