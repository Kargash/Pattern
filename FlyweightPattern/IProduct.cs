namespace FlyweightPattern
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        void Display();
    }
}
