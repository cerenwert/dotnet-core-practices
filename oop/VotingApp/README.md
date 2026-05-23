# Voting Uygulaması - C#

Konsol tabanlı kullanıcı oylama uygulaması.  
Kullanıcılar sisteme giriş yapabilir, ana kategori ve alt kategori seçerek oy verebilir ve sonuçları yüzdelik olarak görüntüleyebilir.

---

# Özellikler

- Kullanıcı kayıt ve giriş sistemi
- Ana kategori ve alt kategori yapısı
- Menü tabanlı seçim sistemi
- Alt kategorilere oy verebilme
- Toplam oy sayısını gösterme
- Yüzdelik oy sonuçları
- Büyük/küçük harf duyarsız kullanıcı kontrolü
- Hatalı girişlerde `TryParse` ile güvenli input kontrolü
- OOP yapısına uygun servis ve model mimarisi

---

# Kullanılan Yapılar

- C#
- .NET Console Application
- OOP (Object Oriented Programming)
- List<T>
- LINQ
- Namespace yapısı
- Service Layer mantığı

---

# Kategori Yapısı

## Sanat
- Resim
- Heykel
- Müzik
- Tiyatro
- Sinema

## Spor
- Futbol
- Basketbol
- Voleybol
- Tenis
- Yüzme

## Teknoloji
- Yazılım
- Donanım
- Yapay Zeka
- Siber Güvenlik
- Oyun Geliştirme

## Seyahat
- Doğa
- Kültür
- Macera
- Tatil
- Gezi Rehberi

## Yemek
- Türk Mutfağı
- Dünya Mutfağı
- Vejetaryen
- Vegan
- Tatlı

## Moda
- Giyim
- Aksesuar
- Ayakkabı
- Çanta
- Takı

## Sağlık
- Beslenme
- Egzersiz
- Zihinsel Sağlık
- Hastalıklar
- Sağlıklı Yaşam

---

# Uygulama Akışı

1. Kullanıcı username girer
2. Kullanıcı sistemde kayıtlı mı kontrol edilir
3. Ana kategoriler listelenir
4. Kullanıcı ana kategori seçer
5. Alt kategoriler listelenir
6. Kullanıcı alt kategori seçer
7. Oy sisteme kaydedilir
8. Kullanıcı isterse sonuçları görüntüleyebilir

---

# Örnek Kullanım

```text
=== VOTING APP ===

Please enter your username:
umut

Welcome back umut

--- MAIN CATEGORIES ---

1 - Sanat
2 - Spor
3 - Teknoloji
4 - Sağlık

Select main category:
3

--- SUB CATEGORIES ---

1 - Yazılım
2 - Donanım
3 - Yapay Zeka
4 - Siber Güvenlik

Select sub category:
3

You voted for Yapay Zeka
Total votes: 1

Would you like to see voting results? (yes/no):
yes

## Örnek Sonuç Ekranı

```text
--- VOTING RESULTS ---

Teknoloji

 - Yazılım: 2 votes (%20.0)
 - Donanım: 1 votes (%10.0)
 - Yapay Zeka: 5 votes (%50.0)
 - Siber Güvenlik: 2 votes (%20.0)

Total votes cast: 10
```