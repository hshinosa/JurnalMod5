
public class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T Angka1, T Angka2, T Angka3)
    {
        
        return (dynamic)Angka1 + (dynamic)Angka2 + (dynamic)Angka3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13,02,22));
    }
}