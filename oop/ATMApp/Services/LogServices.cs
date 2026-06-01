using System;
using System.IO;

namespace ATMApp.Services;
public class LogServices
{
    private readonly string logPath =
        "Logs/logs.txt";

    public void LogTransaction(
        string cardNumber,
        string transactionType,
        decimal amount)
    {
       string logEntry =$"{DateTime.Now} | TRANSACTION | {cardNumber} | {transactionType} | {amount} TL";

        try
        {
            File.AppendAllText(logPath, logEntry + Environment.NewLine);// her log ayrı olması için environment.newline ekledik
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging transaction: {ex.Message}");
        }
    }
      public void LogFraud(
        string cardNumber,
        string message)
    {
           string logEntry = $"{DateTime.Now} | FRAUD | {cardNumber} | {message}";
        try
        {
            File.AppendAllText("Logs/Logs.txt", logEntry + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging fraud attempt: {ex.Message}");
        }
    }
}