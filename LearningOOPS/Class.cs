

using System;
public class Finance{
    private decimal balance;

    public Finance(decimal initialbalance){
        this.balance = initialbalance;
    }

    public decimal withdraw(decimal amount){
        if( amount<0 || amount > balance){
           return 0;
        }
        else{
            balance -= amount;
            return balance;
        }
    }

    public decimal deposit(decimal amount){
        if(amount<0){
            return 0;
        }
        else{
            balance += amount;
            return balance;
        }
    }

    public static void Main(string[] args){
        Finance finance = new Finance(1000);
        decimal result = finance.withdraw(2000);
        if(result==0){
            Console.WriteLine("can't process withdrawal ");
        }
        else{
            Console.WriteLine(result);
        }

        decimal result2 = finance.deposit(200);
        if(result2==0){
            Console.WriteLine("Can't process deposit");
        }
        else{
            Console.WriteLine(result2);
        }
    }
}
