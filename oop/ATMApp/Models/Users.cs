using System;

namespace ATMApp.Models;

public class Users
{
    public string Name { get; set; }

    public string Pin { get; set; }

    public decimal Balance { get; set; }

    public string CardNumber { get; set; }

    public Users(
        string name,
        string pin,
        decimal balance,
        string cardNumber)
    {
        Name = name;
        Pin = pin;
        Balance = balance;
        CardNumber = cardNumber;
    }
}