 # Voting Uygulaması - C#

Konsol tabanlı, kullanıcı kayıtlı oylama uygulaması. Önceden tanımlı kategorilerde oy verme, kayıt sistemi ve detaylı sonuç raporu içeren modern bir C# uygulaması.

## Özellikler

- Pre-defined kategoriler ile oylama
- Kullanıcı kayıt ve giriş sistemi
- Kayıtlı olmayan kullanıcılar anında kayıt olup oylamaya devam edebilir
- Her kategoride tek seçim
- Oylama sonunda **rakamsal** ve **yüzdesel** sonuç gösterimi
- Veriler JSON dosyalarında kalıcı olarak saklanır
- Kolayca yeni kategori ve seçenek eklenebilir

### Örnek Kategoriler
- **Film Kategorileri**
- **Tech Stack Kategorileri**
- **Spor Kategorileri**

## Gereksinimler

- .NET 8.0 (önerilen) veya .NET 6.0
- Visual Studio 2022 veya VS Code

## Kurulum ve Çalıştırma

```bash
git clone <repo-url>
cd VotingApp

dotnet restore
dotnet build
dotnet run

```text
### Ana Menü
=== VOTING UYGULAMASI ===
1. Oylamaya Başla
2. Sonuçları Görüntüle
3. Çıkış
Seçiminiz: 
```text
### Kullanıcı Giriş / Kayıt
Username: ceren123
Bu kullanıcı bulunamadı. Kayıt olmak ister misiniz? (E/H): E
Şifre: ******
Kayıt başarılı! Oylamaya devam ediliyor...
### Oylama Ekranı
=== OYLAMA ===
Mevcut Kategoriler:
1. Film Kategorileri
2. Tech Stack Kategorileri
3. Spor Kategorileri

Kategori seçin (1-3): 1

En İyi Film
1. Inception
2. The Matrix
3. Interstellar
4. Dune: Part Two
Oyunuzu girin (1-4): 3

### Sonuç Ekranı
=== OYLAMA SONUÇLARI ===
En İyi Film
1. Inception           : 15 oy   (%37.5)
2. The Matrix          : 12 oy   (%30.0)
3. Interstellar        : 8 oy    (%20.0)
4. Dune: Part Two      : 5 oy    (%12.5)

## Kullanılan Teknolojiler

- C#
- .NET
- JSON Serialization
- Console Application
- OOP
