# Reverse Words – Console Application (C#)

## 📌 Problem Tanımı
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı (**n**) alınır.  
Ardından kullanıcıdan **n adet kelime** girmesi istenir.  
Kullanıcının girdiği kelimeler **sondan başa doğru** console’a yazdırılır.

---

## 🧠 Algoritma
1. Kullanıcıdan pozitif bir sayı (n) al
2. n adet kelimeyi bir diziye kaydet
3. Diziyi tersten dolaş
4. Kelimeleri console’a yazdır

---

## 🧩 Kullanılan Yapılar
- `do-while` → Pozitif sayı kontrolü
- `string[]` → Kelimeleri saklamak için
- `for` → Kelime almak için
- `LINQ Reverse()` → Tersten yazdırma
- `foreach` → Diziyi dolaşmak için

---

## 💻 C# Kod Çözümü

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n;

        do
        {
            Console.Write("Pozitif bir sayı girin (n): ");
        }
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        string[] kelimeler = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. kelime: ");
            kelimeler[i] = Console.ReadLine();
        }

        Console.WriteLine("\nKelimeler sondan başa doğru:");

        foreach (var kelime in kelimeler.Reverse())
        {
            Console.WriteLine(kelime);
        }
    }
}
