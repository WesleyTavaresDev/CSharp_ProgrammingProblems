namespace FirstAccount
{
    class Bank
    {
        public void GetBankAccount()
        {
            Console.WriteLine("------ First Account ------");
            
            Account heikkisAccount = new Account("Heikki's account", 100.00d);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00d);

            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);

            heikkisAccount.Withdrawal(20d);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance);
            heikkisSwissAccount.Deposit(200d);
            Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);

            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);
        }
    }
}