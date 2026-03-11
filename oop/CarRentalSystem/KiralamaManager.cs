namespace ArabaKiralama.Managers
{
    public class KiralamaManager
    {
        private List<Araba> arabalar;

        public KiralamaManager(List<Araba> arabalar)
        {
            this.arabalar = arabalar;
        }
        public void ArabaListesi()
        {
         Console.WriteLine("Kiralanailir Araba Listesi:");
            for(int i =0; i<arabalar.Count;i++)
            { 
                if(!arabalar[i].KiralandiMi)
                {
                    Console.WriteLine($"{i + 1}. Marka: {arabalar[i].Marka}, Model: {arabalar[i].Model}");
                }
            }
        }
         public void AracKirala(Musteri musteri)
        {
            if (musteri.KiraladigiArac != null)
            {
                Console.WriteLine("Zaten bir araç kiraladınız.");
                return;
            }
            var uygunArabalar = arabalar.Where(a => !a.KiralandiMi).ToList();
            Console.Write("Kiralamak istediğiniz araç numarası: ");

            if (!int.TryParse(Console.ReadLine(), out int secim))
            {
                Console.WriteLine("Geçersiz giriş.");
                return;
            }

            if (secim < 1 || secim > uygunArabalar.Count)
            {
                Console.WriteLine("Geçersiz araç numarası.");
                return;
            }

            Araba araba = uygunArabalar[secim - 1];

            if (!araba.KiralandiMi)
            {
                araba.Kirala();
                musteri.KiraladigiArac = araba;
                Console.WriteLine("Araç kiralandı.");
            }
            else
            {
                Console.WriteLine("Bu araç zaten kiralanmış.");
            }
        }
        public void AracıTeslimEt(Musteri musteri)
        {
            if (musteri.KiraladigiArac==null)   
            {
                Console.WriteLine("Kiralanmış bir aracınız yok.");
                return;
            }
            musteri.KiraladigiArac.KiralandiMi=false;
            Console.WriteLine( $"Teslim edilen araç: {musteri.KiraladigiArac.Marka} {musteri.KiraladigiArac.Model}");
            musteri.KiraladigiArac = null;

            Console.WriteLine("Araç başarıyla teslim edildi.");
        }
        public void KiralamayiIptalEt(Musteri musteri)
        {
            if (musteri.KiraladigiArac == null)
            {
                Console.WriteLine("Kiralanmış bir aracınız yok.");
                return;
            }
            musteri.KiraladigiArac.KiralandiMi=false;
            Console.WriteLine($"Kiralama iptal edilen araç: {musteri.KiraladigiArac}");
            musteri.KiraladigiArac = null;
            Console.WriteLine("Kiralama iptal edildi.");
        }
    }    
}
