using System;
using System.IO;
using ATMApp.Models;

namespace ATMApp.Services;

public class AuthService
{
    private List<Users> users;

    public AuthService()
    {
        users = new List<Users>();
        LoadUsers();
    }

    private void LoadUsers()
    {
        if (File.Exists("Data/users.txt"))
        {
            string[] lines = File.ReadAllLines("Data/users.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 4)
                {
                    string cardNumber = parts[0].Trim();
                    string pin = parts[1].Trim();
                    string name = parts[2].Trim();
                    decimal balance = decimal.Parse(parts[3].Trim());

                    users.Add(new Users(name,pin,balance,cardNumber));
                }
                else
                {
                    Console.WriteLine( $"Invalid user data: {line}");
                }
            }
        }
        else
        {
            Console.WriteLine("users.txt bulunamadı");
        }
    }

    public Users ?Login(string cardNumber,string pin)
    {
        foreach (Users user in users)
        {
            if (user.CardNumber == cardNumber && user.Pin == pin)
            {
                return user;
            }
        }

        return null;
    }
    public void updateUserData(string cardnumber,decimal newbalance)
    {
        string[] lines=File.ReadAllLines("Data/Users.txt");
        for(int i=0;i<lines.Length;i++)
        {
            string[]parts=lines[i].Split(',');
            if(parts[0].Trim()==cardnumber)
            {
                
                lines[i] =$"{parts[0]},{parts[1]},{parts[2]},{newbalance}";
            }
        }
        File.WriteAllLines("Data/Users.txt",lines);
    }
    
}