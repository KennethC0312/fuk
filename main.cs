using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Globalization;

class main
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hi");
        Bank.Saving Kenneth = new Bank.Saving("Kenneth", "P!gs5623", 1000);

        Kenneth.deposit(100);
        Kenneth.withdrawal(100);
    }
}

public class Bank
{
    protected string name;
    protected string password;
    protected int money;

    public Bank(string user_name, string passworded, int Money)
    {
        name = user_name;
        password = passworded;
        money = Money;
        Console.WriteLine("Welcome to dumb Bank");
    }

    protected bool password_check(string check_pass)
    {
        return check_pass.Equals(password);
    }
}

public class Saving : Bank
    {
        public Saving(string user_name, string passworded, int Money) : base(user_name, passworded, Money)
        {
        }

        public void deposit(int amount)
        {
            base.money += amount;
            Console.WriteLine($"You now have ${base.money} in your bank");
        }

        public void withdrawal(int amount)
        {
            if (amount > base.money)
            {
                Console.WriteLine("You do not have enough money to withdraw");
            }
            else
            {
                base.money -= amount;
                Console.WriteLine($"You withdrew ${amount} and ${base.money} remains");
            }
        }
    }
