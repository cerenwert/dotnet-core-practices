
namespace ArabaKiralama
{
    public class Araba :Arac
    {
        public Araba(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }
        public override void Bilgileri()
        {
            Console.WriteLine($"Araba Markası: {Marka}, Model: {Model}");
        }
    }

}