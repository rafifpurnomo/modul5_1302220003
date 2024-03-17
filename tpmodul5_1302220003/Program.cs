public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("masukan nama anda: ");
        string nama = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(nama);
    }
}
