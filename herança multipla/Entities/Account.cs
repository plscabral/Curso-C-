namespace aulas.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account(){
            
        }
        public Account(int number, string holder, double balance){
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdrawn(double amount){
            Balance -= amount;
        }

        public void Deposit(double amount){
            Balance += amount;
        }
    }
}