internal class Program
{
    public static void Main(string[] args)
    {
        const int Scale = 23000;
        Console.WriteLine("Nhap vao so Dollar ma ban co");
        int usd  = int.Parse(Console.ReadLine());
        Console.WriteLine($"So tien VND ma ban co la {Scale*usd}");
    }
}