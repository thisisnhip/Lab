public class Cats : Animal
{
    public string name { get; set; }
    public Cats(float weight, float height, string name ) : base( weight, height )
    {
        this.name = name;
    }
    public override void Show()
    {
        System.Console.WriteLine($"Bạn mèo {name} nặng {weight} cao {height}");   
    }
}