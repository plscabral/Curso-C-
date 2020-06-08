namespace Aula.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(){

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
        :base(number,holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance(){
            Balance += Balance * InterestRate;
        }
         
        public override void Withdrawn(double amount) {
            base.Withdrawn(amount);
            Balance -= 2.0;
        }
	}
}