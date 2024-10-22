public abstract class Animal 
{
    public float weight;
    public float height;
    public Animal (float weight, float height)
    {
        this.weight = weight;
        this.height = height;
    }
    public abstract void Show();
}