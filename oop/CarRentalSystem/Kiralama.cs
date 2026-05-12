namespace ArabaKiralama
{
    public class Kiralama
    {
        public Arac Arac { get; set; }= null!;

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public Musteri Musteri { get; set; } = null!;
    }
}