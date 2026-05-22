# GeometryProject

Bu proje kullanıcıdan alınan geometrik şekle göre alan ve çevre hesaplamaları yapan bir C# console uygulamasıdır.

## Desteklenen Şekiller

- Circle
- Rectangle
- Square
- Triangle

## Özellikler

- Kullanıcıdan dinamik veri alır
- Alan hesaplar
- Çevre hesaplar
- Interface tabanlı yapı kullanır
- Single Responsibility mantığına uygun geliştirilmiştir
- Hatalı girişlerde kontrol sağlar

## Kullanılan Teknolojiler

- C#
- .NET 10
- Console Application
- OOP
- Interface Yapısı

## Proje Yapısı

Projede tüm geometrik şekiller `IShape` interface’ini implement eder.

```csharp
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
