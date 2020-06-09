﻿using System.Globalization;
using System;
using System.Collections.Generic;
using aula.Entities;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Account> list = new List<Account>();

           list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
           list.Add(new BusinessAccount(1002,"Maria", 500.00, 400.0));
           list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
           list.Add(new BusinessAccount(1004,"Anna", 500.00, 500.0));

           double sum = 0.0; 
           foreach(Account acc in list){
               sum += acc.Balance;
           }

           Console.WriteLine("Total Balance: " + sum.ToString("f2", CultureInfo.InvariantCulture));
           foreach(Account acc in list){
               acc.Withdrawn(10.0);
           }

           foreach(Account acc in list){
               Console.WriteLine("Update balance for account " 
                + acc.Number 
                + ": "
                + acc.Balance.ToString("f2", CultureInfo.InvariantCulture));
           }
        }
    }
}
