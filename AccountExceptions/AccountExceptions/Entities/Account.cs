using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountExceptions.Entities.Exceptions;

namespace AccountExceptions.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account(int number, string name, double balance, double withDrawLimit)
        {
            CheckNumber(number);
            CheckBalance(balance);
            CheckWithdrawLimit(withDrawLimit);

            Number = number;
            Name = name;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double Amount)
        {
            CheckBalance(Amount);
            Balance += Amount;
        }

        public void Withdraw(double Amount)
        {
            CheckWithdraw(Amount);
            Balance -= Amount;
        }

        private void CheckBalance(double value)
        {
            if (Balance < 0)
            {
                throw new DomainException("You cannot enter a negative Deposit. ");
            }
        }

        private void CheckWithdraw(double value) 
        {
            if(value < 0)
            {
                throw new DomainException("You cannot Withdraw a negative value");
            }
            if(value > WithDrawLimit)
            {
                throw new DomainException("The value entered as exceeded the withdrawal limit.");
            }
            if(value > Balance)
            {
                throw new DomainException("Value unavaliable to withdraw, your account does not have this amount avaiable.");
            }
        }

        public void CheckWithdrawLimit(double value)
        {
            if (value < 0)
            {
                Console.WriteLine("You cannot enter a withdraw limit negative.");
            }
        }

        private void CheckNumber(int number) 
        {
        if (number <= 0)
            {
                throw new DomainException("You cannot enter a negative number account. ");
            }
        }

        public override string ToString()
        {
            return $"Number Account: {Number}\nHolder Name: {Name}\nBalance: R${Balance}";
        }
    }
}
