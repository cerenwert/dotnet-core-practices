using System;
using System.Collections.Generic;
using System.Linq;
using VotingApp.Models;

namespace VotingApp.Services;

public class UserService
{
    private List<User> users = new List<User>();

    public User GetUser()
    {
        Console.Write("Please enter your username: ");

        string name = Console.ReadLine() ?? "Anonymous";

        return new User
        {
            Name = name
        };
    }

    public void AddUser(string name)
    {
        users.Add(new User { Name = name });

        Console.WriteLine("User successfully added.");
    }

    public List<User> GetAllUsers()
    {
        return users;
    }

    public bool UserExists(string name)
    {
        return users.Any(u =>
            u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public User? FindUserByName(string name)
    {
        return users.FirstOrDefault(u =>
            u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void RemoveUser(string name)
    {
        var user = FindUserByName(name);

        if (user != null)
        {
            users.Remove(user);

            Console.WriteLine("User successfully removed.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void UpdateUserName(string oldName, string newName)
    {
        var user = FindUserByName(oldName);

        if (user != null)
        {
            user.Name = newName;

            Console.WriteLine("User name successfully updated.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void ClearUsers()
    {
        users.Clear();

        Console.WriteLine("All users have been cleared.");
    }

    public void ShowUsers()
    {
        Console.WriteLine("\n--- USERS ---");

        foreach (User user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
}