public class DataGeneric<T>
{
    private T Data;
    public DataGeneric(T data) => Data = data;

    public void printData()
    {
        Console.WriteLine("data yang tersimpan :" + Data);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("masukan NIM anda");
        string nim = Console.ReadLine();
        DataGeneric<string> dataNim = new DataGeneric<string>(nim);
        dataNim.printData();
    }
}