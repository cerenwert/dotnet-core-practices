using System;
using System.Collections.Generic;
using TodoBoardApp;
class Program
{
    static Board board = new Board();

    static Dictionary<int, string> team = new Dictionary<int, string>()
    {
        {1,"Umut"},
        {2,"Ceren"},
        {3,"Ahmet"}
    };
     static void Main()
    {
        // Varsayılan kartlar
        board.Todo.Add(new Card("Login", "Login sayfası yapılacak", 1, "M"));
        board.InProgress.Add(new Card("API", "API geliştiriliyor", 2, "L"));
        board.Done.Add(new Card("UI", "UI tamamlandı", 3, "S"));

        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("1 - Board Listele");
            Console.WriteLine("2 - Kart Ekle");
            Console.WriteLine("3 - Kart Sil");
            Console.WriteLine("4 - Kart Taşı");
            Console.WriteLine("5 - Çıkış");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    BoardListele();
                    break;

                case "2":
                    KartEkle();
                    break;

                case "3":
                    KartSil();
                    break;

                case "4":
                    KartTasi();
                    break;

                case "5":
                    return;
            }
        }
    }

    static void BoardListele()
    {
        Console.WriteLine("\nTODO LINE");
        foreach (var card in board.Todo)
            KartYaz(card);

        Console.WriteLine("\nIN PROGRESS");
        foreach (var card in board.InProgress)
            KartYaz(card);

        Console.WriteLine("\nDONE");
        foreach (var card in board.Done)
            KartYaz(card);
    }

    static void KartYaz(Card card)
    {
        Console.WriteLine("Başlık : " + card.Baslik);
        Console.WriteLine("İçerik : " + card.Icerik);
        Console.WriteLine("Atanan : " + team[card.AtananKisiID]);
        Console.WriteLine("Büyüklük : " + card.Buyukluk);
        Console.WriteLine("-");
    }

    static void KartEkle()
    {
        Console.Write("Başlık: ");
        string baslik = Console.ReadLine();

        Console.Write("İçerik: ");
        string icerik = Console.ReadLine();

        Console.Write("Atanan Kişi ID: ");
        int kisi = int.Parse(Console.ReadLine());

        Console.Write("Büyüklük (XS,S,M,L,XL): ");
        string boyut = Console.ReadLine();

        board.Todo.Add(new Card(baslik, icerik, kisi, boyut));
    }

    static void KartSil()
    {
        Console.Write("Silinecek kart başlığı: ");
        string baslik = Console.ReadLine();

        board.Todo.RemoveAll(x => x.Baslik == baslik);
        board.InProgress.RemoveAll(x => x.Baslik == baslik);
        board.Done.RemoveAll(x => x.Baslik == baslik);
    }

    static void KartTasi()
    {
        Console.Write("Kart başlığı: ");
        string baslik = Console.ReadLine();

        Card card = board.Todo.Find(x => x.Baslik == baslik);

        if (card != null)
        {
            board.Todo.Remove(card);
            board.InProgress.Add(card);
        }
    }
}