using System.Globalization;
using System;

namespace aula.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime duedate, double amount){
            DueDate = duedate;
            Amount = amount;
        }

        public override string ToString(){
            return DueDate.ToString("dd/MM/yyyy") 
                +  " - " 
                + Amount.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}