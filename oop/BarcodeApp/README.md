# Barcode Generator / Reader

## Project Summary 

This project is a C# Console Application developed with .NET. It allows users to generate a barcode from text input, save it as a PNG image, and read the generated barcode to retrieve the encoded data.

The application uses the **ZXing.Net** library for barcode generation and decoding, while **System.Drawing.Common** is used for image processing. The barcode format implemented in this project is **CODE_128**.

Note:
This application uses System.Drawing.Common and ZXing.Windows.Compatibility,
therefore it is intended to run on Windows environments.

### Features

* Generate barcodes from user input
* Save barcodes as PNG files
* Read barcodes from image files
* Display decoded barcode data
* Menu-driven console interface

### Technologies & Libraries

* C#
* .NET 10
* Console Application
* ZXing.Net
* ZXing.Net.Bindings.Windows.Compatibility
* System.Drawing.Common

### Topics Practiced

* File Writing
* File Reading
* Third-Party Library Integration
* Methods
* Conditional Statements
* Loops
* Barcode Generation
* Barcode Decoding

---

## Türkçe Özet

Bu proje, C# ve .NET kullanılarak geliştirilmiş bir konsol uygulamasıdır. Kullanıcının girdiği veriyi barkoda dönüştürür, PNG formatında kaydeder ve daha sonra oluşturulan barkodu okuyarak içerisindeki veriyi ekrana yazdırır.

Projede barkod oluşturma ve okuma işlemleri için **ZXing.Net**, resim işlemleri için ise **System.Drawing.Common** kütüphaneleri kullanılmıştır. Barkod formatı olarak **CODE_128** tercih edilmiştir.

### Yapılan İşlemler

* Kullanıcıdan veri alma
* Barkod oluşturma
* PNG dosyasına kaydetme
* Dosyadan barkod okuma
* Barkod içeriğini ekrana yazdırma
* Menü tabanlı kullanım

### Uygulanan Konular

* Dosyaya Yazma
* Dosyadan Okuma
* 3rd Party Library Kullanımı
* Metotlar
* Koşul Yapıları
* Döngüler
* Barkod Üretme ve Okuma

## Challenges & Solutions

### ZXing Generic Type Errors

Issue:
BarcodeWriter<TOutput> requires 1 type arguments

Solution:
Installed ZXing.Net.Bindings.Windows.Compatibility package and added:

using ZXing.Windows.Compatibility;

