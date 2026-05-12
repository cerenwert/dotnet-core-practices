using System;

class Program
{
    static void Main()
    {
        PhoneBookManager manager = new PhoneBookManager();
        bool working = true;

        while (working)
        {
            Console.WriteLine("\nTelefon Rehberi Uygulamasına Hoşgeldiniz!");
            Console.WriteLine("1 - Numara Ekle");
            Console.WriteLine("2 - Numara Sil");
            Console.WriteLine("3 - Numaraları Listele");
            Console.WriteLine("4 - Numara Ara");
            Console.WriteLine("5 - Numara Güncelle");
            Console.WriteLine("6 - Çıkış");

            Console.Write("Seçiminiz: ");

            int choice;
            bool result = int.TryParse(Console.ReadLine(), out choice);

            if (!result)
            {
                Console.WriteLine("Geçersiz giriş.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    manager.AddContact();
                    break;

                case 2:
                    manager.DeleteContact();
                    break;

                case 3:
                    manager.ListContact();
                    break;

                case 4:
                    manager.SearchContact();
                    break;

                case 5:
                    manager.UpdateContact();
                    break;

                case 6:
                    working = false;
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }

        Console.WriteLine("Uygulamadan çıkılıyor. İyi günler!");
    }
}