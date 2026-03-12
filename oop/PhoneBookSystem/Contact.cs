public class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Surname { get; set; }

    public Contact(string name,string surname,string phoneNumber,string email)
    {
        Name=name;
        Surname=surname;
        PhoneNumber=phoneNumber;
        Email=email;
    }
}