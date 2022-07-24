namespace FirstAccount
{
    class Bank
    {
        static void Main()
        {
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);

            heikkisAccount.Withdrawal(20);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
            heikkisSwissAccount.Deposit(200);
            Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);
        }
    }
}