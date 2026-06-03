using ATMApp.Models;
using ATMApp.Services;

AuthService authService = new AuthService();
ATMService atmService = new ATMService();
EODServices eodServices = new EODServices();

Console.WriteLine("===== ATM UYGULAMASI =====");

Console.Write("Kart Numarası: ");
string? cardNumber = Console.ReadLine();

Console.Write("PIN: ");
string? pin = Console.ReadLine();

Users? user = authService.Login(cardNumber!, pin!);

if (user != null)
{
    Console.WriteLine($"Hoşgeldiniz, {user.Name}!");

    bool exit = false;

    while (!exit)
    {
        Console.WriteLine("\n===== MENÜ =====");
        Console.WriteLine("1. Para Çekme");
        Console.WriteLine("2. Para Yatırma");
        Console.WriteLine("3. Bakiye Görüntüleme");
        Console.WriteLine("4. Çıkış");

        Console.Write("Seçiminiz: ");

        string? choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Çekmek istediğiniz miktar: ");
                decimal withdrawAmount = decimal.Parse(Console.ReadLine()!);
                atmService.Withdraw(user, withdrawAmount);
                break;
            case "2":
                Console.Write("Yatırmak istediğiniz miktar: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine()!);
                atmService.Deposit(user, depositAmount);
                break;
            case "3":
                atmService.showBalance(user);
                break;
            case "4":
                exit = true;
                eodServices.GenerateEndOfDay();
                Console.WriteLine("Çıkış yapıldı. İyi günler!");
                break;
            default:
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                break;
        }
    }
}
else
{
    Console.WriteLine("Geçersiz kart numarası veya PIN.");
}