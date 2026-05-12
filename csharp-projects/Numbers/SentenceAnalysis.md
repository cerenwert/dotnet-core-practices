# Sentence Analysis – Console Application (C#)

## 📌 Problem Tanımı
Bir konsol uygulamasında kullanıcıdan bir **cümle** girmesi istenir.  
Girilen cümledeki:

- **Toplam kelime sayısı**
- **Toplam harf sayısı**

console’a yazdırılır.

---

## 🧠 Algoritma
1. Kullanıcıdan bir cümle al
2. Cümleyi boşluklara göre böl
3. Boş kelimeleri temizle
4. Kelime sayısını hesapla
5. Cümledeki harfleri say
6. Sonuçları console’a yazdır

---

## 🧩 Kullanılan Yapılar
- `Split()` → kelime sayısını bulmak için
- `StringSplitOptions.RemoveEmptyEntries` → boş kelimeleri temizlemek için
- `char.IsLetter` → sadece harfleri saymak için
- `LINQ Count()` → harf sayısını hesaplamak için

---

## 💻 C# Kod Çözümü

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine();

        // Kelime sayısı
        string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;
        Console.WriteLine($"Girdiğiniz cümlede {kelimeSayisi} kelime var");

        // Harf sayısı
        int harfSayisi = cumle.Count(char.IsLetter);
        Console.WriteLine($"Girdiğiniz cümlede {harfSayisi} harf var");
    }
}
