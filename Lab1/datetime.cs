internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu rong hinh chu nhat");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu cao hinh chu nhat");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine($"Chu vi hinh chu nhat la {(width + height)*2}");
        Console.WriteLine($"Dien tich hinh chu nhat la {width*height}");
    }
}