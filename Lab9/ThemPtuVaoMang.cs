internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        System.Console.WriteLine("Nhap so phan tu mang");
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n+1];
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"Nhap phan tu thu {i}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine("Mang co cac phan tu la");
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine(array[i] + "\t");
        }
        System.Console.WriteLine("\n");
        System.Console.WriteLine("Nhap so can chen");
        int x = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap vi tri can chen");
        int p = int.Parse(Console.ReadLine());

        for (int i = n; i >= p; i--)
        {
            array[i] = array[i-1];
        }
        array[p-1] = x;
        for (var i = 0; i<= n; i++)
        {
            System.Console.Write(array[i] + "\t");
        }
    }
}