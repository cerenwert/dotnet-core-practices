using System;
using ATMApp.Models;

namespace ATMApp.Services;

public class ATMService
{
    private readonly LogServices logService;
    private readonly AuthService authService;

    public ATMService()
    {
        logService = new LogServices();
        authService = new AuthService();
    }
    public void Withdraw(Users user, decimal amount)//para çekme işlemi
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
            return;
        }

        if (user.Balance >= amount)
        {
            user.Balance -= amount;
            authService.updateUserData( user.CardNumber, user.Balance );
            logService.LogTransaction(user.CardNumber, "withdrawal", amount);
            Console.WriteLine($"Withdrawal successful. New balance: {user.Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");

            logService.LogFraud(user.CardNumber,"INSUFFICIENT FUNDS");
        }
       
    }  
      
    public void Deposit(Users user,decimal amount)//para yatırma işlemi
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
            return;
        }

       user.Balance+=amount;logService.LogTransaction(user.CardNumber,"deposit",amount);
       authService.updateUserData( user.CardNumber, user.Balance );
       logService.LogTransaction(user.CardNumber,"deposit",amount);
        Console.WriteLine($"Deposit successful. New balance: {user.Balance:C}");
    }
    public void showBalance(Users user)//bakiye görüntüleme işlemi
    {
        Console.WriteLine($"Current balance: {user.Balance:C}");
    }
}