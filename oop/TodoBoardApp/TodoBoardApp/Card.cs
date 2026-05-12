public class Card
{
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public int AtananKisiID { get; set; }
    public string Buyukluk { get; set; }

    public Card(string baslik, string icerik, int kisiId, string buyukluk)
    {
        Baslik = baslik;
        Icerik = icerik;
        AtananKisiID = kisiId;
        Buyukluk = buyukluk;
    }
}