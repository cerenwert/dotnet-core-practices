# Even Numbers – Console Application

## Problem
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini istenir (n, m).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini istenir.
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırılır.

---

## Algorithm
1. Kullanıcıdan pozitif bir n ve m değeri al
2. n adet pozitif sayı iste
3. Her sayı için:
   - Eğer sayı m'e eşit ve ya tam bölünüyorsa console’a yazdır

---
## C# Solution

```csharp
// See https://aka.ms/new-console-template for more information
using System.Reflection;

int n, m;
do
{
    Console.WriteLine("pozitif bir n sayı girin");
}
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

Console.WriteLine("girdiğiniz sayı pozitifdir.");

do
{
    Console.WriteLine("pozitif bir m sayı girin");
}
while(!int.TryParse(Console.ReadLine(),out m) || m <= 0);
Console.WriteLine($"{n} adet sayı giriniz.");
for (int i = 1; i <= n; i++) 
{
    int sayı;
    do
    {
        Console.WriteLine($"{i}.sayı");
    } 
    while (!int.TryParse(Console.ReadLine(),out sayı)||sayı<=0);

    if (sayı % m == 0||m==sayı) 
    {
        Console.WriteLine($"{sayı} sayısı {m} sayısına tam bölünür ya da eşittir.");
    }
}
