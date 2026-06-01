using System;
using System.IO;
using ATMApp.Models;
using System.Collections.Generic;
namespace ATMApp.Services;
public class EODServices
{
    private readonly string logPath="Logs/logs.txt";
    public void GenerateEndOfDay()
    {
        if(!File.Exists(logPath))
        {
            Console.WriteLine("Log dosyası bulunamadı.");
            return;
        }
        string[] logs=File.ReadAllLines(logPath);
        List<string> transactions=new List<string>();
        List<string> frauds=new List<string>();
        foreach(string log in logs)
        {
            if(log.Contains("transaction"))
            {
                transactions.Add(log);;
            }
            else if(log.Contains("fraud"))
            {
                frauds.Add(log);
            }
        }
        string report =$"""===== GÜN SONU RAPORU =====RAPOR TARIHI: {DateTime.Now:dd.MM.yyyy}TRANSACTIONS--------------------------------------------{string.Join(Environment.NewLine, transactions)}FRAUD LOGS--------------------------------------------{string.Join(Environment.NewLine, frauds)}===== RAPOR SONU =====""";
        string eodFileName =$"Logs/EOD_{DateTime.Now:ddMMyyyy}.txt";File.WriteAllText(eodFileName,report);
        Console.WriteLine($"Gün sonu raporu oluşturuldu: {eodFileName}");
    }
}