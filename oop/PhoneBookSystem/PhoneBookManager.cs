using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneBookManager
{
    public List<Contact> contacts = new List<Contact>();

    private static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    private static bool IsValidPhone(string phoneNumber)
    {
        return Regex.IsMatch(phoneNumber, @"^0[0-9]{10}$");
    }

    public void AddContact()
    {
        Console.Write("İsim: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Soyisim: ");
        string surname = Console.ReadLine() ?? "";

        string phoneNumber;

        do
        {
            Console.Write("Telefon Numarası (05551234567): ");
            phoneNumber = Console.ReadLine() ?? "";

            if (!IsValidPhone(phoneNumber))
                Console.WriteLine("Telefon numarası formatı yanlış.");

        } while (!IsValidPhone(phoneNumber));

        string email;

        do
        {
            Console.Write("Email: ");
            email = Console.ReadLine() ?? "";

            if (!IsValidEmail(email))
                Console.WriteLine("Email formatı yanlış.");

        } while (!IsValidEmail(email));

        Contact newContact = new Contact(name, surname, phoneNumber, email);
        contacts.Add(newContact);

        Console.WriteLine("Numara eklendi.");
    }

    public void ListContact()
    {
        Console.WriteLine("\nTelefon Rehberi:");

        foreach (Contact c in contacts)
        {
            Console.WriteLine($"İsim: {c.Name}, Soyisim: {c.Surname}, Telefon: {c.PhoneNumber}, Email: {c.Email}");
        }
    }

    public void SearchContact()
    {
        Console.Write("Aramak istediğiniz bilgi: ");
        string search = Console.ReadLine() ?? "";

        var results = contacts.Where(c =>
            c.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
            c.Surname.Contains(search, StringComparison.OrdinalIgnoreCase) ||
            c.PhoneNumber.Contains(search) ||
            c.Email.Contains(search, StringComparison.OrdinalIgnoreCase)
        ).ToList();

        if (results.Any())
        {
            Console.WriteLine("\nBulunan kişiler:");

            foreach (var c in results)
            {
                Console.WriteLine($"İsim: {c.Name}, Soyisim: {c.Surname}, Telefon: {c.PhoneNumber}, Email: {c.Email}");
            }
        }
        else
        {
            Console.WriteLine("Hiçbir sonuç bulunamadı.");
        }
    }
    public void DeleteContact() 
    {
        Console.Write("Silmek istenilen İsim: ");
        string name = (Console.ReadLine() ?? "").Trim();

        Console.Write("Soyisim: ");
        string surname = (Console.ReadLine() ?? "").Trim();

        Contact contactToDelete = contacts.FirstOrDefault(c =>
            c.Name.Trim().Equals(name, StringComparison.OrdinalIgnoreCase) &&
            c.Surname.Trim().Equals(surname, StringComparison.OrdinalIgnoreCase)
        );

        if (contactToDelete != null)
        {
            Console.WriteLine($"{contactToDelete.Name} {contactToDelete.Surname} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
            string answer = Console.ReadLine() ?? "";

            if (answer.ToLower() == "y")
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine("Kişi silindi.");
            }
            else
            {
                Console.WriteLine("Silme işlemi iptal edildi.");
            }
        }
        else
        {
            Console.WriteLine("Numara bulunamadı.");
        }
    }
    public void UpdateContact()
    {
        Console.Write("Güncellemek istediğiniz kişi: ");
        string search = Console.ReadLine() ?? "";

        var contactToUpdate = contacts.FirstOrDefault(c =>
            c.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
            c.Surname.Contains(search, StringComparison.OrdinalIgnoreCase) ||
            c.PhoneNumber.Contains(search) ||
            c.Email.Contains(search, StringComparison.OrdinalIgnoreCase));

        if (contactToUpdate == null)
        {
            Console.WriteLine("Kişi bulunamadı.");
            return;
        }

        Console.WriteLine("\nBulunan kişi:");
        Console.WriteLine($"{contactToUpdate.Name} {contactToUpdate.Surname}");
        Console.WriteLine($"Telefon: {contactToUpdate.PhoneNumber}");
        Console.WriteLine($"Email: {contactToUpdate.Email}");

        Console.Write("\nTüm bilgileri güncellemek istiyor musunuz? (y/n): ");
        string answer = Console.ReadLine() ?? "";

        if (answer.ToLower() == "y")
        {
            Console.Write("Yeni isim: ");
            contactToUpdate.Name = Console.ReadLine() ?? contactToUpdate.Name;

            Console.Write("Yeni soyisim: ");
            contactToUpdate.Surname = Console.ReadLine() ?? contactToUpdate.Surname;

            Console.Write("Yeni telefon: ");
            contactToUpdate.PhoneNumber = Console.ReadLine() ?? contactToUpdate.PhoneNumber;

            Console.Write("Yeni email: ");
            contactToUpdate.Email = Console.ReadLine() ?? contactToUpdate.Email;
        }
        else
        {
            Console.Write("Yeni isim (boş bırak = değişmesin): ");
            string newName = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(newName))
                contactToUpdate.Name = newName;

            Console.Write("Yeni soyisim (boş bırak = değişmesin): ");
            string newSurname = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(newSurname))
                contactToUpdate.Surname = newSurname;

            Console.Write("Yeni telefon (boş bırak = değişmesin): ");
            string newPhone = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(newPhone))
                contactToUpdate.PhoneNumber = newPhone;

            Console.Write("Yeni email (boş bırak = değişmesin): ");
            string newEmail = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(newEmail))
                contactToUpdate.Email = newEmail;
        }

        Console.WriteLine("\nKişi başarıyla güncellendi.");
    }
}