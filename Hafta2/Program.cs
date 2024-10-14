class Ogrenci 
{
    public String adi;
    public int yasi;
    public String sinifi;

    public void BilgileriYazdir()
    {
        Console.WriteLine("Adi" + adi + " " + "Yasi:" + yasi.ToString() + " " + "Sinifi:" + sinifi);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogr1 = new Ogrenci();
        ogr1.adi = "Ahmet";
        ogr1.yasi = 20;
        ogr1.sinifi = "10B";

        ogr1.BilgileriYazdir();
    }
}
