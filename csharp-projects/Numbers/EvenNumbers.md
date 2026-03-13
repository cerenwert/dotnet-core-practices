# Even Numbers – Console Application

## Problem
Kullanıcıdan pozitif bir sayı (n) alınır.  
Ardından kullanıcıdan n adet pozitif sayı istenir.  
Girilen sayılardan **çift olanlar** console’a yazdırılır.

---

## Algorithm
1. Kullanıcıdan pozitif bir n değeri al
2. n adet pozitif sayı iste
3. Her sayı için:
   - Eğer sayı çift ise console’a yazdır

---

## C# Solution

```csharp
int n;

do
{
    Console.Write("Pozitif bir n değeri girin: ");
}
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

for (int i = 1; i <= n; i++)
{
    int sayi;
    do
    {
        Console.Write($"{i}. sayı: ");
    }
    while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0);

    if (sayi % 2 == 0)
    {
        Console.WriteLine($"Çift sayı: {sayi}");
    }
}
