internal class Program
{
    private static void Main(string[] args)
    {
        Cats cat1 = new Cats(15,30,"Lucy");
        // cat1.height = 15;
        // cat1.weight = 30;
        // cat1.name = "Lucy";
        cat1.Show();

        // Dog dog1 = new Dog(5,10,"Yeti","white");
        // dog1.Show();
    }
}