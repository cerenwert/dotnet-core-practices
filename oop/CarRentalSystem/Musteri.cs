namespace ArabaKiralama{
    public class Musteri
    {
        public string Ad { get; set; }="";
        public string Soyad { get; set; }="";
        public string Telefon { get; set; }="";
        public string Email { get; set; }="";

        public Araba? KiraladigiArac { get; set; }
        public void Bilgileri()
        {
            Console.WriteLine($"Müşteri Adı: {Ad} {Soyad}, Telefon: {Telefon}, Email: {Email}");
        }
    }
}