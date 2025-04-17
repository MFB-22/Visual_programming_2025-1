class circle
{
    private double radius;
    public circle(double r) { radius = r; }
    public double Getarea() { return radius * radius * 3.14; }
}
class Program
{
    static void Main(string[] args)
    {
        circle donut = new circle(5);
        circle pie = new circle(10);
        circle pizza = new circle(20);
        Console.WriteLine("도넛: " + donut.Getarea());
        Console.WriteLine("파이: " + pie.Getarea());
        Console.WriteLine("피자: " + pizza.Getarea());
    }
}