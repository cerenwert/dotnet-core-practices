# Character Rotation App

Bu C# console uygulaması kullanıcıdan alınan kelimelerin ilk harfini sona taşıyarak yeni bir çıktı oluşturur.

## 📌 Özellikler

- Kullanıcıdan metin alır
- Kelimeleri boşluklara göre ayırır
- Her kelimenin ilk harfini sona taşır
- Tek harfli kelimeleri değiştirmez
- Konsola dönüştürülmüş çıktıyı yazdırır

## 🧠 Kullanılan Yapılar

- `string.Split()`
- `Substring()`
- `foreach`
- Ternary operator (`? :`)
- String indexing

## 🚀 Çalışma Mantığı

Program kullanıcıdan bir metin alır:

```txt
Input: merhaba dünya
Output:elloh orldw
