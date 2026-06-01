# ATM Application

## About the Project

This project is a console-based ATM simulation developed with C# and .NET.

Users can log in using their card number and PIN, perform basic banking transactions, and generate an End Of Day (EOD) report. The application uses text files for data storage and logging.

## Features

* User authentication
* Balance inquiry
* Deposit money
* Withdraw money
* Fraud logging for invalid transactions
* Transaction logging
* End Of Day (EOD) report generation
* Read and write operations with text files

## Technologies Used

* C#
* .NET
* Object-Oriented Programming (OOP)
* File I/O Operations

## Project Structure

```text
ATMApp
│
├── Data
│   └── Users.txt
│
├── Logs
│   ├── Logs.txt
│   └── EOD_DDMMYYYY.txt
│
├── Models
│   └── Users.cs
│
├── Services
│   ├── AuthService.cs
│   ├── ATMService.cs
│   ├── LogServices.cs
│   └── EODServices.cs
│
└── Program.cs
```

## User Data Format

Users are stored in the following format:

```text
CardNumber,PIN,Name,Balance
```

Example:

```text
1001,1234,Umut Ates,15000
1002,4321,Ceren Ates,9000
```

## Logging

All transactions are stored in:

```text
Logs/Logs.txt
```

Example:

```text
01.06.2026 | TRANSACTION | 1001 | deposit | 500 TL
01.06.2026 | TRANSACTION | 1001 | withdrawal | 250 TL
01.06.2026 | FRAUD | 1001 | INSUFFICIENT FUNDS
```

## End Of Day Report

When the user exits the application, an EOD report is generated automatically.

Example:

```text
Logs/EOD_01062026.txt
```

The report contains:

* Transaction logs
* Fraud logs
* Daily activity summary

## Learning Objectives

This project was developed to practice:

* Object-Oriented Programming
* File Reading and Writing
* Service Layer Design
* Logging Systems
* Basic ATM Operations
* Console Application Development

```
```
## Turkish Summary

Bu proje, C# ve .NET kullanılarak geliştirilmiş konsol tabanlı bir ATM uygulamasıdır.

Kullanıcılar kart numarası ve PIN bilgileriyle giriş yapabilir, para çekme, para yatırma ve bakiye görüntüleme işlemlerini gerçekleştirebilir. Yapılan işlemler log dosyalarına kaydedilir ve uygulama çıkışında gün sonu raporu oluşturulur.

Bu proje kapsamında Nesne Yönelimli Programlama (OOP), dosya okuma/yazma işlemleri, loglama sistemi ve servis katmanı yapıları uygulanmıştır.
