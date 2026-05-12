namespace ArabaKiralama
{
    public abstract class Arac{
        public string Marka { get; set; }="";
        public string Model { get; set; }="";
        public bool KiralandiMi { get; set; }
        public abstract void Bilgileri();
        public void Kirala()
        {
            if (KiralandiMi)
            {
                Console.WriteLine("Bu araç kiralanmış.");
            }
            else
            {
                KiralandiMi = true;
                Console.WriteLine("Araç başarıyla kiralandı.");
            }
        }
        public void IptalET()
        {
            if(KiralandiMi)
            {
                KiralandiMi = false;
                Console.WriteLine("Kiralama iptal edildi.");
            }
            else
            {
                Console.WriteLine("Bu araç zaten kiralanmamış.");
            }
        }
    };

}