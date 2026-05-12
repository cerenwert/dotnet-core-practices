
namespace ArabaKiralama
{
    public class Motor : Arac
    {
        public Motor(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }

        public override void Bilgileri()
        {
            Console.WriteLine("Motor: " + Marka + " " + Model);
        }
    }
}