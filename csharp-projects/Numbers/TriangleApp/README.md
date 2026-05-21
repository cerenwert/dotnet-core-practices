# TriangleApp

Bu uygulama kullanıcıdan alınan boyuta göre konsolda yıldızlardan oluşan bir piramit çizer.

## Özellikler

- Kullanıcıdan üçgen boyutu alır
- Dinamik piramit oluşturur
- Boşluk ve yıldız hesaplamalarını ayrı metotlarla yapar
- Single Responsibility mantığına uygun şekilde metotlara bölünmüştür

## Kullanılan Teknolojiler

- C#
- .NET 10
- Console Application

## Çalışma Mantığı

Örnek giriş:

5

Örnek çıktı:

    *
   ***
  *****
 *******
*********

## Metotlar

### GetTriangleSize()

Kullanıcıdan üçgen boyutunu alır.

### DrawPyramid(int size)

Piramit yapısını oluşturur.

### PrintStars(int count)

Belirtilen sayıda yıldız basar.

### PrintSpaces(int count)

Girilen sayı kadar boşluk bırakır.

## Çalıştırma

```bash
dotnet run
