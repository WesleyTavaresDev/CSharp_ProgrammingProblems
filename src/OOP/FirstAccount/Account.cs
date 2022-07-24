namespace FirstAccount
{
    class Account
    {
        private string name;
        private double balance;
        public double Balance => balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;    
        }

        public void Withdrawal(double discont) => balance -= discont;
        public void Deposit(double money) => balance += money;

        public override string ToString() => "mount of money: " + balance;
    }
}