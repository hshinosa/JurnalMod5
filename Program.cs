public class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T Angka1, T Angka2, T Angka3)
    {
        return (dynamic)Angka1 + (dynamic)Angka2 + (dynamic)Angka3;
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputData;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputData = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputData.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data" + i + " berisi: " + this.storedData[i] +
                ", yang disimpan pada waktu UTC: " + this.inputData[i]);

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13,02,22));
        SimpleDataBase<long> dataBase = new SimpleDataBase<long>();
        dataBase.AddNewData(13);
        dataBase.AddNewData(02);
        dataBase.AddNewData(22);
        dataBase.AddNewData(20);
        dataBase.AddNewData(07);
        dataBase.AddNewData(9);
        dataBase.PrintAllData();
    }
}